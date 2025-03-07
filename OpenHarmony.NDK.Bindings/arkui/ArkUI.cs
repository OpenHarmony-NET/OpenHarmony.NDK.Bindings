using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Native;

public unsafe static partial class ArkUI
{
    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_DragEvent* OH_ArkUI_NodeEvent_GetDragEvent(ArkUI_NodeEvent* nodeEvent);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_PreDragStatus OH_ArkUI_NodeEvent_GetPreDragStatus(ArkUI_NodeEvent* nodeEvent);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DragEvent_DisableDefaultDropAnimation(ArkUI_DragEvent* @event, [MarshalAs(UnmanagedType.Bool)]bool disable);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DragEvent_SetSuggestedDropOperation(ArkUI_DragEvent* @event, ArkUI_DropOperation dropOperation);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DragEvent_SetDragResult(ArkUI_DragEvent* @event, ArkUI_DragResult result);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DragEvent_SetData(ArkUI_DragEvent* @event, OH_UdmfData* data);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DragAction_SetDragPreviewOption(ArkUI_DragAction* dragAction, ArkUI_DragPreviewOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DragAction_RegisterStatusListener(ArkUI_DragAction* dragAction, void* userData, delegate* unmanaged[Cdecl]<ArkUI_DragAndDropInfo*, void*, void> listener);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DragAction_UnregisterStatusListener(ArkUI_DragAction* dragAction);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_DragStatus OH_ArkUI_DragAndDropInfo_GetDragStatus(ArkUI_DragAndDropInfo* dragAndDropInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_DragEvent* OH_ArkUI_DragAndDropInfo_GetDragEvent(ArkUI_DragAndDropInfo* dragAndDropInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_StartDrag(ArkUI_DragAction* dragAction);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_DrawableDescriptor* OH_ArkUI_DrawableDescriptor_CreateFromPixelMap(OH_PixelmapNativeHandle pixelMap);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_DrawableDescriptor* OH_ArkUI_DrawableDescriptor_CreateFromAnimatedPixelMap(OH_PixelmapNativeHandle* array, int size);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DrawableDescriptor_Dispose(ArkUI_DrawableDescriptor* drawableDescriptor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial OH_PixelmapNativeHandle OH_ArkUI_DrawableDescriptor_GetStaticPixelMap(ArkUI_DrawableDescriptor* drawableDescriptor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial OH_PixelmapNativeHandle* OH_ArkUI_DrawableDescriptor_GetAnimatedPixelMapArray(ArkUI_DrawableDescriptor* drawableDescriptor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DrawableDescriptor_GetAnimatedPixelMapArraySize(ArkUI_DrawableDescriptor* drawableDescriptor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DrawableDescriptor_SetAnimationDuration(ArkUI_DrawableDescriptor* drawableDescriptor, int duration);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DrawableDescriptor_GetAnimationDuration(ArkUI_DrawableDescriptor* drawableDescriptor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DrawableDescriptor_SetAnimationIteration(ArkUI_DrawableDescriptor* drawableDescriptor, int iteration);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DrawableDescriptor_GetAnimationIteration(ArkUI_DrawableDescriptor* drawableDescriptor);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AnimateOption* OH_ArkUI_AnimateOption_Create();


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_Dispose(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial uint OH_ArkUI_AnimateOption_GetDuration(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_AnimateOption_GetTempo(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AnimationCurve OH_ArkUI_AnimateOption_GetCurve(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimateOption_GetDelay(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimateOption_GetIterations(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AnimationPlayMode OH_ArkUI_AnimateOption_GetPlayMode(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ExpectedFrameRateRange* OH_ArkUI_AnimateOption_GetExpectedFrameRateRange(ArkUI_AnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetDuration(ArkUI_AnimateOption* option, int value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetTempo(ArkUI_AnimateOption* option, float value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetCurve(ArkUI_AnimateOption* option, ArkUI_AnimationCurve value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetDelay(ArkUI_AnimateOption* option, int value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetIterations(ArkUI_AnimateOption* option, int value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetPlayMode(ArkUI_AnimateOption* option, ArkUI_AnimationPlayMode value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetExpectedFrameRateRange(ArkUI_AnimateOption* option, ArkUI_ExpectedFrameRateRange* value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimateOption_SetICurve(ArkUI_AnimateOption* option, ArkUI_CurveHandle value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_AnimateOption_GetICurve(ArkUI_AnimateOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_KeyframeAnimateOption* OH_ArkUI_KeyframeAnimateOption_Create(int size);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_KeyframeAnimateOption_Dispose(ArkUI_KeyframeAnimateOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_SetDelay(ArkUI_KeyframeAnimateOption* option, int value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_SetIterations(ArkUI_KeyframeAnimateOption* option, int value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_RegisterOnFinishCallback(ArkUI_KeyframeAnimateOption* option, void* userData, delegate* unmanaged[Cdecl]<void*, void> onFinish);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_SetDuration(ArkUI_KeyframeAnimateOption* option, int value, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_SetCurve(ArkUI_KeyframeAnimateOption* option, ArkUI_CurveHandle value, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_RegisterOnEventCallback(ArkUI_KeyframeAnimateOption* option, void* userData, delegate* unmanaged[Cdecl]<void*, void> @event, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_GetDelay(ArkUI_KeyframeAnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_GetIterations(ArkUI_KeyframeAnimateOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_KeyframeAnimateOption_GetDuration(ArkUI_KeyframeAnimateOption* option, int index);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_KeyframeAnimateOption_GetCurve(ArkUI_KeyframeAnimateOption* option, int index);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AnimatorOption* OH_ArkUI_AnimatorOption_Create(int keyframeSize);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_AnimatorOption_Dispose(ArkUI_AnimatorOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetDuration(ArkUI_AnimatorOption* option, int value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetDelay(ArkUI_AnimatorOption* option, int value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetIterations(ArkUI_AnimatorOption* option, int value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetFill(ArkUI_AnimatorOption* option, ArkUI_AnimationFillMode value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetDirection(ArkUI_AnimatorOption* option, ArkUI_AnimationDirection value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetCurve(ArkUI_AnimatorOption* option, ArkUI_CurveHandle value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetBegin(ArkUI_AnimatorOption* option, float value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetEnd(ArkUI_AnimatorOption* option, float value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetExpectedFrameRateRange(
        ArkUI_AnimatorOption* option, ArkUI_ExpectedFrameRateRange* value);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetKeyframe(
        ArkUI_AnimatorOption* option, float time, float value, int index);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_SetKeyframeCurve(ArkUI_AnimatorOption* option, ArkUI_CurveHandle value, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_GetDuration(ArkUI_AnimatorOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_GetDelay(ArkUI_AnimatorOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_GetIterations(ArkUI_AnimatorOption* option);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AnimationFillMode OH_ArkUI_AnimatorOption_GetFill(ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AnimationDirection OH_ArkUI_AnimatorOption_GetDirection(ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_AnimatorOption_GetCurve(ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_AnimatorOption_GetBegin(ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_AnimatorOption_GetEnd(ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ExpectedFrameRateRange* OH_ArkUI_AnimatorOption_GetExpectedFrameRateRange(ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_AnimatorOption_GetKeyframeTime(ArkUI_AnimatorOption* option, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_AnimatorOption_GetKeyframeValue(ArkUI_AnimatorOption* option, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_AnimatorOption_GetKeyframeCurve(ArkUI_AnimatorOption* option, int index);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_AnimatorEvent_GetUserData(ArkUI_AnimatorEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_AnimatorOnFrameEvent_GetUserData(ArkUI_AnimatorOnFrameEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_AnimatorOnFrameEvent_GetValue(ArkUI_AnimatorOnFrameEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_RegisterOnFrameCallback(
        ArkUI_AnimatorOption* option, void* userData, delegate* unmanaged[Cdecl]<ArkUI_AnimatorOnFrameEvent*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_RegisterOnFinishCallback(ArkUI_AnimatorOption* option, void* userData, delegate* unmanaged[Cdecl]<ArkUI_AnimatorEvent*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_RegisterOnCancelCallback(ArkUI_AnimatorOption* option, void* userData, delegate* unmanaged[Cdecl]<ArkUI_AnimatorEvent*, void> callback);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AnimatorOption_RegisterOnRepeatCallback(ArkUI_AnimatorOption* option, void* userData, delegate* unmanaged[Cdecl]<ArkUI_AnimatorEvent*, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_Animator_ResetAnimatorOption(
        ArkUI_AnimatorHandle animatorHandle, ArkUI_AnimatorOption* option);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_Animator_Play(ArkUI_AnimatorHandle animatorHandle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_Animator_Finish(ArkUI_AnimatorHandle animatorHandle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_Animator_Pause(ArkUI_AnimatorHandle animatorHandle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_Animator_Cancel(ArkUI_AnimatorHandle animatorHandle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_Animator_Reverse(ArkUI_AnimatorHandle animatorHandle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateCurveByType(ArkUI_AnimationCurve curve);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateStepsCurve(int count, [MarshalAs(UnmanagedType.Bool)]bool end);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateCubicBezierCurve(float x1, float y1, float x2, float y2);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateSpringCurve(float velocity, float mass, float stiffness, float damping);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateSpringMotion(float response, float dampingFraction, float overlapDuration);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateResponsiveSpringMotion(
        float response, float dampingFraction, float overlapDuration);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateInterpolatingSpring(float velocity, float mass, float stiffness, float damping);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_CurveHandle OH_ArkUI_Curve_CreateCustomCurve(void* userData, delegate* unmanaged[Cdecl]<float, void*, float> interpolate);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_Curve_DisposeCurve(ArkUI_CurveHandle curveHandle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_TransitionEffect* OH_ArkUI_CreateOpacityTransitionEffect(float opacity);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_TransitionEffect* OH_ArkUI_CreateTranslationTransitionEffect(ArkUI_TranslationOptions* translate);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_TransitionEffect* OH_ArkUI_CreateScaleTransitionEffect(ArkUI_ScaleOptions* scale);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_TransitionEffect* OH_ArkUI_CreateRotationTransitionEffect(ArkUI_RotationOptions* rotate);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_TransitionEffect* OH_ArkUI_CreateMovementTransitionEffect(ArkUI_TransitionEdge edge);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_TransitionEffect* OH_ArkUI_CreateAsymmetricTransitionEffect(
        ArkUI_TransitionEffect* appear, ArkUI_TransitionEffect* disappear);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_TransitionEffect_Dispose(ArkUI_TransitionEffect* effect);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_TransitionEffect_Combine(
        ArkUI_TransitionEffect* firstEffect, ArkUI_TransitionEffect* secondEffect);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_TransitionEffect_SetAnimation(
        ArkUI_TransitionEffect* effect, ArkUI_AnimateOption* animation);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DialogDismissEvent_SetShouldBlockDismiss(ArkUI_DialogDismissEvent* @event, [MarshalAs(UnmanagedType.Bool)]bool shouldBlockDismiss);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_DialogDismissEvent_GetUserData(ArkUI_DialogDismissEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_DialogDismissEvent_GetDismissReason(ArkUI_DialogDismissEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OH_ArkUI_GestureInterruptInfo_GetSystemFlag(ArkUI_GestureInterruptInfo* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_GestureRecognizer* OH_ArkUI_GestureInterruptInfo_GetRecognizer(ArkUI_GestureInterruptInfo* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_GestureEvent* OH_ArkUI_GestureInterruptInfo_GetGestureEvent(ArkUI_GestureInterruptInfo* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GestureInterruptInfo_GetSystemRecognizerType(ArkUI_GestureInterruptInfo* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_GestureEventActionType OH_ArkUI_GestureEvent_GetActionType(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_UIInputEvent* OH_ArkUI_GestureEvent_GetRawInputEvent(ArkUI_GestureEvent* @event);
    
    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_LongPress_GetRepeatCount(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PanGesture_GetVelocity(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PanGesture_GetVelocityX(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PanGesture_GetVelocityY(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PanGesture_GetOffsetX(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PanGesture_GetOffsetY(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_SwipeGesture_GetAngle(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_SwipeGesture_GetVelocity(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_RotationGesture_GetAngle(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PinchGesture_GetScale(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PinchGesture_GetCenterX(ArkUI_GestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PinchGesture_GetCenterY(ArkUI_GestureEvent* @event);
    
    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeHandle OH_ArkUI_GestureEvent_GetNode(ArkUI_GestureEvent* @event);
    
    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetResponseRecognizersFromInterruptInfo(ArkUI_GestureInterruptInfo* @event,
    ArkUI_GestureRecognizerHandleArray* responseChain, int* count);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_SetGestureRecognizerEnabled(ArkUI_GestureRecognizer* recognizer, [MarshalAs(UnmanagedType.Bool)]bool enabled);

    [LibraryImport("libace_ndk.z.so")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OH_ArkUI_GetGestureRecognizerEnabled(ArkUI_GestureRecognizer* recognizer);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetGestureRecognizerState(ArkUI_GestureRecognizer* recognizer, ArkUI_GestureRecognizerState* state);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetGestureEventTargetInfo(ArkUI_GestureRecognizer* recognizer, ArkUI_GestureEventTargetInfo** info);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GestureEventTargetInfo_IsScrollBegin(ArkUI_GestureEventTargetInfo* info, bool* ret);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GestureEventTargetInfo_IsScrollEnd(ArkUI_GestureEventTargetInfo* info, bool* ret);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetPanGestureDirectionMask(ArkUI_GestureRecognizer* recognizer,
        uint* directionMask);

    [LibraryImport("libace_ndk.z.so")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OH_ArkUI_IsBuiltInGesture(ArkUI_GestureRecognizer* recognizer);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetGestureTag(ArkUI_GestureRecognizer* recognizer, sbyte* buffer, int bufferSize, int* result);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetGestureBindNodeId(ArkUI_GestureRecognizer* recognizer, sbyte* nodeId, int size, int* result);

    [LibraryImport("libace_ndk.z.so")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OH_ArkUI_IsGestureRecognizerValid(ArkUI_GestureRecognizer* recognizer);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_ParallelInnerGestureEvent_GetUserData(ArkUI_ParallelInnerGestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_GestureRecognizer* OH_ArkUI_ParallelInnerGestureEvent_GetCurrentRecognizer(
        ArkUI_ParallelInnerGestureEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_ParallelInnerGestureEvent_GetConflictRecognizers(ArkUI_ParallelInnerGestureEvent* @event,
    ArkUI_GestureRecognizerHandleArray* array, int* size);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_SetArkUIGestureRecognizerDisposeNotify(ArkUI_GestureRecognizer* recognizer, delegate* unmanaged[Cdecl]<ArkUI_GestureRecognizer*, void*, void> callback, void* userData);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetNodeHandleFromNapiValue(napi_env env, napi_value frameNode, ArkUI_NodeHandle* handle);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetContextFromNapiValue(napi_env env, napi_value value, ArkUI_ContextHandle* context);



    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetNodeContentFromNapiValue(napi_env env, napi_value value, ArkUI_NodeContentHandle* content);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetDrawableDescriptorFromNapiValue(
        napi_env env, napi_value value, ArkUI_DrawableDescriptor** drawableDescriptor);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_GetDrawableDescriptorFromResourceNapiValue(napi_env env, napi_value value, ArkUI_DrawableDescriptor** drawableDescriptor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavigationId(
        ArkUI_NodeHandle node, sbyte* buffer, int bufferSize, int* writeLength);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavDestinationName(
        ArkUI_NodeHandle node, sbyte* buffer, int bufferSize, int* writeLength);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavStackLength(ArkUI_NodeHandle node, int* length);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavDestinationNameByIndex(
        ArkUI_NodeHandle node, int index, sbyte* buffer, int bufferSize, int* writeLength);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavDestinationId(
        ArkUI_NodeHandle node, sbyte* buffer, int bufferSize, int* writeLength);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavDestinationState(ArkUI_NodeHandle node, ArkUI_NavDestinationState* state);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetNavDestinationIndex(ArkUI_NodeHandle node, int* index);


    [LibraryImport("libace_ndk.z.so")]
    public static partial napi_value OH_ArkUI_GetNavDestinationParam(ArkUI_NodeHandle node);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetRouterPageIndex(ArkUI_NodeHandle node, int* index);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetRouterPageName(
        ArkUI_NodeHandle node, sbyte* buffer, int bufferSize, int* writeLength);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetRouterPagePath(
        ArkUI_NodeHandle node, sbyte* buffer, int bufferSize, int* writeLength);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetRouterPageState(ArkUI_NodeHandle node, ArkUI_RouterPageState* state);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ErrorCode OH_ArkUI_GetRouterPageId(
        ArkUI_NodeHandle node, sbyte* buffer, int bufferSize, int* writeLength);



    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeEventType OH_ArkUI_NodeEvent_GetEventType(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeEvent_GetTargetId(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeHandle OH_ArkUI_NodeEvent_GetNodeHandle(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_UIInputEvent* OH_ArkUI_NodeEvent_GetInputEvent(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeComponentEvent* OH_ArkUI_NodeEvent_GetNodeComponentEvent(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_StringAsyncEvent* OH_ArkUI_NodeEvent_GetStringAsyncEvent(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_NodeEvent_GetUserData(ArkUI_NodeEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeEvent_GetNumberValue(ArkUI_NodeEvent* @event, int index, ArkUI_NumberValue* value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeEvent_GetStringValue(ArkUI_NodeEvent* @event, int index, sbyte** @string, int* stringSize);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeEvent_SetReturnNumberValue(ArkUI_NodeEvent* @event, ArkUI_NumberValue* value, int size);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeAdapterHandle OH_ArkUI_NodeAdapter_Create();


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_NodeAdapter_Dispose(ArkUI_NodeAdapterHandle handle);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_SetTotalNodeCount(ArkUI_NodeAdapterHandle handle, uint size);


    [LibraryImport("libace_ndk.z.so")]
    public static partial uint OH_ArkUI_NodeAdapter_GetTotalNodeCount(ArkUI_NodeAdapterHandle handle);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_RegisterEventReceiver(ArkUI_NodeAdapterHandle handle, void* userData, delegate* unmanaged[Cdecl]<ArkUI_NodeAdapterEvent*, void> receiver);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_NodeAdapter_UnregisterEventReceiver(ArkUI_NodeAdapterHandle handle);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_ReloadAllItems(ArkUI_NodeAdapterHandle handle);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_ReloadItem(
    ArkUI_NodeAdapterHandle handle, uint startPosition, uint itemCount);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_RemoveItem(
    ArkUI_NodeAdapterHandle handle, uint startPosition, uint itemCount);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_InsertItem(
    ArkUI_NodeAdapterHandle handle, uint startPosition, uint itemCount);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_MoveItem(ArkUI_NodeAdapterHandle handle, uint from, uint to);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapter_GetAllItems(ArkUI_NodeAdapterHandle handle, ArkUI_NodeHandle** items, uint* size);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_NodeAdapterEvent_GetUserData(ArkUI_NodeAdapterEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeAdapterEventType OH_ArkUI_NodeAdapterEvent_GetType(ArkUI_NodeAdapterEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeHandle OH_ArkUI_NodeAdapterEvent_GetRemovedNode(ArkUI_NodeAdapterEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial uint OH_ArkUI_NodeAdapterEvent_GetItemIndex(ArkUI_NodeAdapterEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeHandle OH_ArkUI_NodeAdapterEvent_GetHostNode(ArkUI_NodeAdapterEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapterEvent_SetItem(ArkUI_NodeAdapterEvent* @event, ArkUI_NodeHandle node);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeAdapterEvent_SetNodeId(ArkUI_NodeAdapterEvent* @event, int id);

    /**
     * @brief Declares a collection of native node APIs provided by ArkUI.
     *
     * The APIs related to the native node must be called in the main thread.
     *
     * @version 1
     * @since 12
     */


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_LayoutConstraint* OH_ArkUI_NodeCustomEvent_GetLayoutConstraintInMeasure(ArkUI_NodeCustomEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_IntOffset OH_ArkUI_NodeCustomEvent_GetPositionInLayout(ArkUI_NodeCustomEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_DrawContext* OH_ArkUI_NodeCustomEvent_GetDrawContextInDraw(ArkUI_NodeCustomEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeCustomEvent_GetEventTargetId(ArkUI_NodeCustomEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_NodeCustomEvent_GetUserData(ArkUI_NodeCustomEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeHandle OH_ArkUI_NodeCustomEvent_GetNodeHandle(ArkUI_NodeCustomEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeCustomEventType OH_ArkUI_NodeCustomEvent_GetEventType(ArkUI_NodeCustomEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeCustomEvent_GetCustomSpanMeasureInfo(
        ArkUI_NodeCustomEvent* @event, ArkUI_CustomSpanMeasureInfo* info);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeCustomEvent_SetCustomSpanMetrics(
        ArkUI_NodeCustomEvent* @event, ArkUI_CustomSpanMetrics* metrics);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeCustomEvent_GetCustomSpanDrawInfo(
        ArkUI_NodeCustomEvent* @event, ArkUI_CustomSpanDrawInfo* info);



    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeContent_RegisterCallback(ArkUI_NodeContentHandle content, delegate* unmanaged[Cdecl]<ArkUI_NodeContentEvent*, void> callback);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeContentEventType OH_ArkUI_NodeContentEvent_GetEventType(ArkUI_NodeContentEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_NodeContentHandle OH_ArkUI_NodeContentEvent_GetNodeContentHandle(ArkUI_NodeContentEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeContent_SetUserData(ArkUI_NodeContentHandle content, void* userData);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_NodeContent_GetUserData(ArkUI_NodeContentHandle content);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeContent_AddNode(ArkUI_NodeContentHandle content, ArkUI_NodeHandle node);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeContent_RemoveNode(ArkUI_NodeContentHandle content, ArkUI_NodeHandle node);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeContent_InsertNode(ArkUI_NodeContentHandle content, ArkUI_NodeHandle node, int position);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeUtils_GetLayoutSize(ArkUI_NodeHandle node, ArkUI_IntSize* size);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeUtils_GetLayoutPosition(ArkUI_NodeHandle node, ArkUI_IntOffset* localOffset);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeUtils_GetLayoutPositionInWindow(ArkUI_NodeHandle node, ArkUI_IntOffset* globalOffset);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeUtils_GetLayoutPositionInScreen(ArkUI_NodeHandle node, ArkUI_IntOffset* screenOffset);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeUtils_GetPositionWithTranslateInWindow(ArkUI_NodeHandle node, ArkUI_IntOffset* translateOffset);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_NodeUtils_GetPositionWithTranslateInScreen(ArkUI_NodeHandle node, ArkUI_IntOffset* translateOffset);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_NodeUtils_AddCustomProperty(ArkUI_NodeHandle node, char* name, char* value);


    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_NodeUtils_RemoveCustomProperty(ArkUI_NodeHandle node, char* name);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_List_CloseAllSwipeActions(ArkUI_NodeHandle node, void* userData, delegate* unmanaged[Cdecl]<void*, void> onFinish);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_ContextHandle OH_ArkUI_GetContextByNode(ArkUI_NodeHandle node);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_RegisterSystemColorModeChangeEvent(ArkUI_NodeHandle node,
        void* userData, delegate* unmanaged[Cdecl]<ArkUI_SystemColorMode, void*, void> onColorModeChange);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_UnregisterSystemColorModeChangeEvent(ArkUI_NodeHandle node);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_RegisterSystemFontStyleChangeEvent(ArkUI_NodeHandle node,
        void* userData, delegate* unmanaged[Cdecl]<ArkUI_SystemFontStyleEvent*, void*, void> onFontStyleChange);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_UnregisterSystemFontStyleChangeEvent(ArkUI_NodeHandle node);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_SystemFontStyleEvent_GetFontSizeScale(ArkUI_SystemFontStyleEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_SystemFontStyleEvent_GetFontWeightScale(ArkUI_SystemFontStyleEvent* @event);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_StyledString* OH_ArkUI_StyledString_Create(
    OH_Drawing_TypographyStyle* style, OH_Drawing_FontCollection* collection);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_StyledString_Destroy(ArkUI_StyledString* handle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_StyledString_PushTextStyle(ArkUI_StyledString* handle, OH_Drawing_TextStyle* style);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_StyledString_AddText(ArkUI_StyledString* handle, sbyte* content);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_StyledString_PopTextStyle(ArkUI_StyledString* handle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial OH_Drawing_Typography* OH_ArkUI_StyledString_CreateTypography(ArkUI_StyledString* handle);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_StyledString_AddPlaceholder(ArkUI_StyledString* handle, OH_Drawing_PlaceholderSpan* placeholder);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_UIInputEvent_GetType(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_UIInputEvent_GetAction(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_UIInputEvent_GetSourceType(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_UIInputEvent_GetToolType(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial long OH_ArkUI_UIInputEvent_GetEventTime(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial uint OH_ArkUI_PointerEvent_GetPointerCount(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_PointerEvent_GetPointerId(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetX(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetXByIndex(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetY(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetYByIndex(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetWindowX(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetWindowXByIndex(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetWindowY(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetWindowYByIndex(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetDisplayX(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetDisplayXByIndex(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetDisplayY(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetDisplayYByIndex(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetPressure(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetTiltX(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetTiltY(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetTouchAreaWidth(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetTouchAreaHeight(ArkUI_UIInputEvent* @event, uint pointerIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial uint OH_ArkUI_PointerEvent_GetHistorySize(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial long OH_ArkUI_PointerEvent_GetHistoryEventTime(ArkUI_UIInputEvent* @event, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial uint OH_ArkUI_PointerEvent_GetHistoryPointerCount(ArkUI_UIInputEvent* @event, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_PointerEvent_GetHistoryPointerId(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryX(ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryY(ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryWindowX(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryWindowY(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryDisplayX(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryDisplayY(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryPressure(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryTiltX(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryTiltY(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);

    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryTouchAreaWidth(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial float OH_ArkUI_PointerEvent_GetHistoryTouchAreaHeight(
    ArkUI_UIInputEvent* @event, uint pointerIndex, uint historyIndex);


    [LibraryImport("libace_ndk.z.so")]
    public static partial double OH_ArkUI_AxisEvent_GetVerticalAxisValue(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial double OH_ArkUI_AxisEvent_GetHorizontalAxisValue(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial double OH_ArkUI_AxisEvent_GetPinchAxisScaleValue(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_PointerEvent_SetInterceptHitTestMode(ArkUI_UIInputEvent* @event, HitTestMode mode);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_MouseEvent_GetMouseButton(ArkUI_UIInputEvent* @event);

    
    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_MouseEvent_GetMouseAction(ArkUI_UIInputEvent* @event);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_PointerEvent_SetStopPropagation(ArkUI_UIInputEvent* @event, [MarshalAs(UnmanagedType.Bool)]bool stopPropagation);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void* OH_ArkUI_QueryModuleInterfaceByName(ArkUI_NativeAPIVariantKind type, sbyte* structName);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityProviderRegisterCallback(
    ArkUI_AccessibilityProvider* provider, ArkUI_AccessibilityProviderCallbacks* callbacks);

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_SendAccessibilityAsyncEvent(
        ArkUI_AccessibilityProvider* provider, ArkUI_AccessibilityEventInfo* eventInfo,
        delegate* unmanaged[Cdecl]<int, void> callback);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AccessibilityElementInfo* OH_ArkUI_AddAndGetAccessibilityElementInfo(
        ArkUI_AccessibilityElementInfoList* list);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetElementId(
        ArkUI_AccessibilityElementInfo* elementInfo, int elementId);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetParentId(
        ArkUI_AccessibilityElementInfo* elementInfo, int parentId);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetComponentType(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** componentType);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetContents(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** contents);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetHintText(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** hintText);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityText(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** accessibilityText);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityDescription(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** accessibilityDescription);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetChildNodeIds(
        ArkUI_AccessibilityElementInfo* elementInfo, int childCount, long* childNodeIds);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetOperationActions(ArkUI_AccessibilityElementInfo* elementInfo,
        int operationCount, ArkUI_AccessibleAction* operationActions);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetScreenRect(
        ArkUI_AccessibilityElementInfo* elementInfo, ArkUI_AccessibleRect* screenRect);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetCheckable(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)]bool checkable);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetChecked(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool @checked);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetFocusable(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool focusable);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetFocused(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool isFocused);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetVisible(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool isVisible);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityFocused(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool accessibilityFocused);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetSelected(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool selected);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetClickable(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool clickable);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetLongClickable(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool longClickable);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetEnabled(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool isEnabled);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetIsPassword(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool isPassword);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetScrollable(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool scrollable);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetEditable(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool editable);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetIsHint(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)] bool isHint);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetRangeInfo(
        ArkUI_AccessibilityElementInfo* elementInfo, ArkUI_AccessibleRangeInfo* rangeInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetGridInfo(
        ArkUI_AccessibilityElementInfo* elementInfo, ArkUI_AccessibleGridInfo* gridInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetGridItemInfo(
        ArkUI_AccessibilityElementInfo* elementInfo, ArkUI_AccessibleGridItemInfo* gridItem);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetSelectedTextStart(
        ArkUI_AccessibilityElementInfo* elementInfo, int selectedTextStart);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetSelectedTextEnd(
        ArkUI_AccessibilityElementInfo* elementInfo, int selectedTextEnd);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetCurrentItemIndex(
        ArkUI_AccessibilityElementInfo* elementInfo, int currentItemIndex);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetStartItemIndex(
        ArkUI_AccessibilityElementInfo* elementInfo, int startItemIndex);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetEndItemIndex(
        ArkUI_AccessibilityElementInfo* elementInfo, int endItemIndex);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetItemCount(
        ArkUI_AccessibilityElementInfo* elementInfo, int itemCount);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityOffset(
        ArkUI_AccessibilityElementInfo* elementInfo, int offset);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityGroup(
        ArkUI_AccessibilityElementInfo* elementInfo, [MarshalAs(UnmanagedType.Bool)]bool accessibilityGroup);


    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityLevel(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** accessibilityLevel);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetZIndex(
        ArkUI_AccessibilityElementInfo* elementInfo, int zIndex);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetAccessibilityOpacity(
        ArkUI_AccessibilityElementInfo* elementInfo, float opacity);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetBackgroundColor(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** backgroundColor);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetBackgroundImage(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** backgroundImage);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetBlur(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** blur);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityElementInfoSetHitTestBehavior(
        ArkUI_AccessibilityElementInfo* elementInfo, sbyte** hitTestBehavior);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AccessibilityElementInfo* OH_ArkUI_CreateAccessibilityElementInfo();

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DestoryAccessibilityElementInfo(ArkUI_AccessibilityElementInfo* elementInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial ArkUI_AccessibilityEventInfo* OH_ArkUI_CreateAccessibilityEventInfo();

    [LibraryImport("libace_ndk.z.so")]
    public static partial void OH_ArkUI_DestoryAccessibilityEventInfo(ArkUI_AccessibilityEventInfo* eventInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityEventSetEventType(
        ArkUI_AccessibilityEventInfo* eventInfo, ArkUI_AccessibilityEventType eventType);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityEventSetTextAnnouncedForAccessibility(
        ArkUI_AccessibilityEventInfo* eventInfo,  sbyte** textAnnouncedForAccessibility);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityEventSetRequestFocusId(
        ArkUI_AccessibilityEventInfo* eventInfo, int requestFocusId);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_AccessibilityEventSetElementInfo(
        ArkUI_AccessibilityEventInfo* eventInfo, ArkUI_AccessibilityElementInfo* elementInfo);

    [LibraryImport("libace_ndk.z.so")]
    public static partial int OH_ArkUI_FindAccessibilityActionArgumentByKey(
        ArkUI_AccessibilityActionArguments* arguments, sbyte** key, sbyte** value);
}
