// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--==
//============================================================
//
// Class:  DebuggerAttributes
//
// Purpose: Attributes for debugger
//
//===========================================================  



namespace System.Diagnostics
{
    //| <include path='docs/doc[@for="DebuggerStepThroughAttribute"]/*' />
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
    public sealed class DebuggerStepThroughAttribute : Attribute
    {
        //| <include path='docs/doc[@for="DebuggerStepThroughAttribute.DebuggerStepThroughAttribute"]/*' />
        public DebuggerStepThroughAttribute () {}
    }

    //| <include path='docs/doc[@for="DebuggerHiddenAttribute"]/*' />
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor, Inherited = false)]
    public sealed class DebuggerHiddenAttribute : Attribute
    {
       //| <include path='docs/doc[@for="DebuggerHiddenAttribute.DebuggerHiddenAttribute"]/*' />
       public DebuggerHiddenAttribute () {}
    }

   // Attribute class used by the compiler to mark modules.
    // If present, then debugging information for everything in the
   // assembly was generated by the compiler, and will be preserved
   // by the Runtime so that the debugger can provide full functionality
   // in the case of JIT attach. If not present, then the compiler may
   // or may not have included debugging information, and the Runtime
   // won't preserve the debugging info, which will make debugging after
   // a JIT attach difficult.
    //| <include path='docs/doc[@for="DebuggableAttribute"]/*' />
    [AttributeUsage(AttributeTargets.Assembly|AttributeTargets.Module, AllowMultiple = false)]
    public sealed class DebuggableAttribute : Attribute
    {
        bool m_isJITTrackingEnabled;
        bool m_isJITOptimizerDisabled;

        //| <include path='docs/doc[@for="DebuggableAttribute.DebuggableAttribute"]/*' />
        public DebuggableAttribute(bool isJITTrackingEnabled,
                                   bool isJITOptimizerDisabled)
        {
            m_isJITTrackingEnabled = isJITTrackingEnabled;
            m_isJITOptimizerDisabled = isJITOptimizerDisabled;
        }

        //| <include path='docs/doc[@for="DebuggableAttribute.IsJITTrackingEnabled"]/*' />
        public bool IsJITTrackingEnabled
        {
            get { return m_isJITTrackingEnabled; }
        }

        //| <include path='docs/doc[@for="DebuggableAttribute.IsJITOptimizerDisabled"]/*' />
        public bool IsJITOptimizerDisabled
        {
            get { return m_isJITOptimizerDisabled; }
        }
    }
}

