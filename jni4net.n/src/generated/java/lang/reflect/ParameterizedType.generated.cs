//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ParameterizedType : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        java.lang.reflect.Type[] getActualTypeArguments();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        global::java.lang.reflect.Type getOwnerType();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        global::java.lang.reflect.Type getRawType();
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class ParameterizedType_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__ParameterizedType.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.ParameterizedType))]
    internal sealed unsafe partial class @__ParameterizedType : global::java.lang.Object, global::java.lang.reflect.ParameterizedType {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getActualTypeArguments0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOwnerType1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getRawType2;
        
        protected @__ParameterizedType(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.reflect.@__ParameterizedType.staticClass = staticClass;
            global::java.lang.reflect.@__ParameterizedType._getActualTypeArguments0 = env.GetMethodID(global::java.lang.reflect.@__ParameterizedType.staticClass, "getActualTypeArguments", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.@__ParameterizedType._getOwnerType1 = env.GetMethodID(global::java.lang.reflect.@__ParameterizedType.staticClass, "getOwnerType", "()Ljava/lang/reflect/Type;");
            global::java.lang.reflect.@__ParameterizedType._getRawType2 = env.GetMethodID(global::java.lang.reflect.@__ParameterizedType.staticClass, "getRawType", "()Ljava/lang/reflect/Type;");
        }
        
        public java.lang.reflect.Type[] getActualTypeArguments() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Type[])(env.ConvertArrayToNet<java.lang.reflect.Type>(env.CallObjectMethod(this, global::java.lang.reflect.@__ParameterizedType._getActualTypeArguments0))));
        }
        
        public global::java.lang.reflect.Type getOwnerType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Type>(env.CallObjectMethod(this, global::java.lang.reflect.@__ParameterizedType._getOwnerType1));
        }
        
        public global::java.lang.reflect.Type getRawType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Type>(env.CallObjectMethod(this, global::java.lang.reflect.@__ParameterizedType._getRawType2));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__ParameterizedType);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getActualTypeArguments", "getActualTypeArguments0", "()[Ljava/lang/reflect/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getOwnerType", "getOwnerType1", "()Ljava/lang/reflect/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getRawType", "getRawType2", "()Ljava/lang/reflect/Type;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* getActualTypeArguments0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()[Ljava/lang/reflect/Type;
            // ()[Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.reflect.ParameterizedType real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.ParameterizedType>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.getActualTypeArguments());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* getOwnerType1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/reflect/Type;
            // ()Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.reflect.ParameterizedType real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.ParameterizedType>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.getOwnerType());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* getRawType2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/reflect/Type;
            // ()Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.reflect.ParameterizedType real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.ParameterizedType>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.getRawType());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.reflect.@__ParameterizedType(env);
            }
        }
    }
    #endregion
}