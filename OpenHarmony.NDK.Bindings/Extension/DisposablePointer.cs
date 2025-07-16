using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings
{
    /// <summary>
    /// 提供字符串到 <see cref="DisposablePointer"/> 的转换扩展方法
    /// </summary>
    public static class DisposablePointerExtension
    {
        /// <summary>
        /// 将字符串转换为 <see cref="DisposablePointer"/>，分配非托管内存
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DisposablePointer ToPointer(this string str)
        {
            if (str == null)
            {
                return new DisposablePointer(IntPtr.Zero);
            }

            // 分配非托管内存
            IntPtr ptr = Marshal.StringToHGlobalAnsi(str);
            return new DisposablePointer(ptr);
        }
    }

    /// <summary>
    /// MarshalPtr类用于管理非托管内存的分配和释放
    /// </summary>
    public class DisposablePointer : IDisposable
    {
        /// <summary>
        /// 指示是否已释放资源
        /// </summary>
        private bool _disposedValue;

        /// <summary>  
        /// 指向分配的非托管内存的指针  
        /// </summary>  
        public IntPtr Pointer { get; private set; }

        /// <summary>  
        /// 构造函数，初始化指针  
        /// </summary>  
        /// <param name="ptr">非托管内存的指针</param>  
        public DisposablePointer(IntPtr ptr)
        {
            Pointer = ptr;
        }

        /// <summary>
        /// 提供从DisposablePointer到IntPtr的隐式转换
        /// </summary>
        /// <param name="disposablePointer">可释放的指针对象</param>
        public static implicit operator IntPtr(DisposablePointer disposablePointer)
        {
            return disposablePointer?.Pointer ?? IntPtr.Zero;
        }

        /// <summary>
        /// 提供从DisposablePointer到char*的隐式转换
        /// </summary>
        /// <param name="disposablePointer">可释放的指针对象</param>
        public static unsafe implicit operator char*(DisposablePointer disposablePointer)
        {
            if (disposablePointer == null || disposablePointer.Pointer == IntPtr.Zero)
            {
                return null;
            }

            return (char*)disposablePointer.Pointer;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (Pointer != IntPtr.Zero)
                {
                    // 释放分配的非托管内存  
                    Marshal.FreeHGlobal(Pointer);

                    // 将指针重置为零  
                    Pointer = IntPtr.Zero;
                }

                _disposedValue = true;
            }
        }

        /// <summary>
        /// 析构函数，释放非托管资源
        /// </summary>
        ~DisposablePointer()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
