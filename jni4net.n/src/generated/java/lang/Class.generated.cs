//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class Class : global::java.lang.Object, global::java.io.Serializable, global::java.lang.reflect.GenericDeclaration, global::java.lang.reflect.Type, global::java.lang.reflect.AnnotatedElement {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTypeParameters0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAnnotation1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAnnotations2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredAnnotations3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAnnotationPresent4;
        
        internal static global::net.sf.jni4net.jni.MethodId _forName5;
        
        internal static global::net.sf.jni4net.jni.MethodId _forName6;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAssignableFrom7;
        
        internal static global::net.sf.jni4net.jni.MethodId _isInstance8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getModifiers9;
        
        internal static global::net.sf.jni4net.jni.MethodId _isInterface10;
        
        internal static global::net.sf.jni4net.jni.MethodId _isArray11;
        
        internal static global::net.sf.jni4net.jni.MethodId _isPrimitive12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSuperclass13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getComponentType14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName15;
        
        internal static global::net.sf.jni4net.jni.MethodId _asSubclass16;
        
        internal static global::net.sf.jni4net.jni.MethodId _cast17;
        
        internal static global::net.sf.jni4net.jni.MethodId _desiredAssertionStatus18;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCanonicalName19;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClassLoader20;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClasses21;
        
        internal static global::net.sf.jni4net.jni.MethodId _getConstructor22;
        
        internal static global::net.sf.jni4net.jni.MethodId _getConstructors23;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredClasses24;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredConstructor25;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredConstructors26;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredField27;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredFields28;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredMethod29;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaredMethods30;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass31;
        
        internal static global::net.sf.jni4net.jni.MethodId _getEnclosingClass32;
        
        internal static global::net.sf.jni4net.jni.MethodId _getEnclosingConstructor33;
        
        internal static global::net.sf.jni4net.jni.MethodId _getEnclosingMethod34;
        
        internal static global::net.sf.jni4net.jni.MethodId _getEnumConstants35;
        
        internal static global::net.sf.jni4net.jni.MethodId _getField36;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFields37;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericInterfaces38;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericSuperclass39;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInterfaces40;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMethod41;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMethods42;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPackage43;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProtectionDomain44;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResource45;
        
        internal static global::net.sf.jni4net.jni.MethodId _getResourceAsStream46;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSigners47;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSimpleName48;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAnnotation49;
        
        internal static global::net.sf.jni4net.jni.MethodId _isAnonymousClass50;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEnum51;
        
        internal static global::net.sf.jni4net.jni.MethodId _isLocalClass52;
        
        internal static global::net.sf.jni4net.jni.MethodId _isMemberClass53;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynthetic54;
        
        internal static global::net.sf.jni4net.jni.MethodId _newInstance55;
        
        protected internal Class(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Class.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.Class.staticClass = staticClass;
            global::java.lang.Class._getTypeParameters0 = env.GetMethodID(global::java.lang.Class.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
            global::java.lang.Class._getAnnotation1 = env.GetMethodID(global::java.lang.Class.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
            global::java.lang.Class._getAnnotations2 = env.GetMethodID(global::java.lang.Class.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
            global::java.lang.Class._getDeclaredAnnotations3 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
            global::java.lang.Class._isAnnotationPresent4 = env.GetMethodID(global::java.lang.Class.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
            global::java.lang.Class._forName5 = env.GetStaticMethodID(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
            global::java.lang.Class._forName6 = env.GetStaticMethodID(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
            global::java.lang.Class._isAssignableFrom7 = env.GetMethodID(global::java.lang.Class.staticClass, "isAssignableFrom", "(Ljava/lang/Class;)Z");
            global::java.lang.Class._isInstance8 = env.GetMethodID(global::java.lang.Class.staticClass, "isInstance", "(Ljava/lang/Object;)Z");
            global::java.lang.Class._getModifiers9 = env.GetMethodID(global::java.lang.Class.staticClass, "getModifiers", "()I");
            global::java.lang.Class._isInterface10 = env.GetMethodID(global::java.lang.Class.staticClass, "isInterface", "()Z");
            global::java.lang.Class._isArray11 = env.GetMethodID(global::java.lang.Class.staticClass, "isArray", "()Z");
            global::java.lang.Class._isPrimitive12 = env.GetMethodID(global::java.lang.Class.staticClass, "isPrimitive", "()Z");
            global::java.lang.Class._getSuperclass13 = env.GetMethodID(global::java.lang.Class.staticClass, "getSuperclass", "()Ljava/lang/Class;");
            global::java.lang.Class._getComponentType14 = env.GetMethodID(global::java.lang.Class.staticClass, "getComponentType", "()Ljava/lang/Class;");
            global::java.lang.Class._getName15 = env.GetMethodID(global::java.lang.Class.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.Class._asSubclass16 = env.GetMethodID(global::java.lang.Class.staticClass, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;");
            global::java.lang.Class._cast17 = env.GetMethodID(global::java.lang.Class.staticClass, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.lang.Class._desiredAssertionStatus18 = env.GetMethodID(global::java.lang.Class.staticClass, "desiredAssertionStatus", "()Z");
            global::java.lang.Class._getCanonicalName19 = env.GetMethodID(global::java.lang.Class.staticClass, "getCanonicalName", "()Ljava/lang/String;");
            global::java.lang.Class._getClassLoader20 = env.GetMethodID(global::java.lang.Class.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
            global::java.lang.Class._getClasses21 = env.GetMethodID(global::java.lang.Class.staticClass, "getClasses", "()[Ljava/lang/Class;");
            global::java.lang.Class._getConstructor22 = env.GetMethodID(global::java.lang.Class.staticClass, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
            global::java.lang.Class._getConstructors23 = env.GetMethodID(global::java.lang.Class.staticClass, "getConstructors", "()[Ljava/lang/reflect/Constructor;");
            global::java.lang.Class._getDeclaredClasses24 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredClasses", "()[Ljava/lang/Class;");
            global::java.lang.Class._getDeclaredConstructor25 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
            global::java.lang.Class._getDeclaredConstructors26 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;");
            global::java.lang.Class._getDeclaredField27 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
            global::java.lang.Class._getDeclaredFields28 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredFields", "()[Ljava/lang/reflect/Field;");
            global::java.lang.Class._getDeclaredMethod29 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
            global::java.lang.Class._getDeclaredMethods30 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;");
            global::java.lang.Class._getDeclaringClass31 = env.GetMethodID(global::java.lang.Class.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.Class._getEnclosingClass32 = env.GetMethodID(global::java.lang.Class.staticClass, "getEnclosingClass", "()Ljava/lang/Class;");
            global::java.lang.Class._getEnclosingConstructor33 = env.GetMethodID(global::java.lang.Class.staticClass, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
            global::java.lang.Class._getEnclosingMethod34 = env.GetMethodID(global::java.lang.Class.staticClass, "getEnclosingMethod", "()Ljava/lang/reflect/Method;");
            global::java.lang.Class._getEnumConstants35 = env.GetMethodID(global::java.lang.Class.staticClass, "getEnumConstants", "()[Ljava/lang/Object;");
            global::java.lang.Class._getField36 = env.GetMethodID(global::java.lang.Class.staticClass, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
            global::java.lang.Class._getFields37 = env.GetMethodID(global::java.lang.Class.staticClass, "getFields", "()[Ljava/lang/reflect/Field;");
            global::java.lang.Class._getGenericInterfaces38 = env.GetMethodID(global::java.lang.Class.staticClass, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;");
            global::java.lang.Class._getGenericSuperclass39 = env.GetMethodID(global::java.lang.Class.staticClass, "getGenericSuperclass", "()Ljava/lang/reflect/Type;");
            global::java.lang.Class._getInterfaces40 = env.GetMethodID(global::java.lang.Class.staticClass, "getInterfaces", "()[Ljava/lang/Class;");
            global::java.lang.Class._getMethod41 = env.GetMethodID(global::java.lang.Class.staticClass, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
            global::java.lang.Class._getMethods42 = env.GetMethodID(global::java.lang.Class.staticClass, "getMethods", "()[Ljava/lang/reflect/Method;");
            global::java.lang.Class._getPackage43 = env.GetMethodID(global::java.lang.Class.staticClass, "getPackage", "()Ljava/lang/Package;");
            global::java.lang.Class._getProtectionDomain44 = env.GetMethodID(global::java.lang.Class.staticClass, "getProtectionDomain", "()Ljava/security/ProtectionDomain;");
            global::java.lang.Class._getResource45 = env.GetMethodID(global::java.lang.Class.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
            global::java.lang.Class._getResourceAsStream46 = env.GetMethodID(global::java.lang.Class.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
            global::java.lang.Class._getSigners47 = env.GetMethodID(global::java.lang.Class.staticClass, "getSigners", "()[Ljava/lang/Object;");
            global::java.lang.Class._getSimpleName48 = env.GetMethodID(global::java.lang.Class.staticClass, "getSimpleName", "()Ljava/lang/String;");
            global::java.lang.Class._isAnnotation49 = env.GetMethodID(global::java.lang.Class.staticClass, "isAnnotation", "()Z");
            global::java.lang.Class._isAnonymousClass50 = env.GetMethodID(global::java.lang.Class.staticClass, "isAnonymousClass", "()Z");
            global::java.lang.Class._isEnum51 = env.GetMethodID(global::java.lang.Class.staticClass, "isEnum", "()Z");
            global::java.lang.Class._isLocalClass52 = env.GetMethodID(global::java.lang.Class.staticClass, "isLocalClass", "()Z");
            global::java.lang.Class._isMemberClass53 = env.GetMethodID(global::java.lang.Class.staticClass, "isMemberClass", "()Z");
            global::java.lang.Class._isSynthetic54 = env.GetMethodID(global::java.lang.Class.staticClass, "isSynthetic", "()Z");
            global::java.lang.Class._newInstance55 = env.GetMethodID(global::java.lang.Class.staticClass, "newInstance", "()Ljava/lang/Object;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        public virtual java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.TypeVariable[])(env.ConvertArrayToNet<java.lang.reflect.TypeVariable>(env.CallObjectMethod(this, global::java.lang.Class._getTypeParameters0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")]
        public virtual global::java.lang.annotation.Annotation getAnnotation(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.annotation.Annotation>(env.CallObjectMethod(this, global::java.lang.Class._getAnnotation1, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/annotation/Annotation;")]
        public virtual java.lang.annotation.Annotation[] getAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.annotation.Annotation[])(env.ConvertArrayToNet<java.lang.annotation.Annotation>(env.CallObjectMethod(this, global::java.lang.Class._getAnnotations2))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/annotation/Annotation;")]
        public virtual java.lang.annotation.Annotation[] getDeclaredAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.annotation.Annotation[])(env.ConvertArrayToNet<java.lang.annotation.Annotation>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredAnnotations3))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Z")]
        public virtual bool isAnnotationPresent(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isAnnotationPresent4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;")]
        public static global::java.lang.Class forName(global::java.lang.String par0, bool par1, global::java.lang.ClassLoader par2) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallStaticObjectMethod(global::java.lang.Class.staticClass, global::java.lang.Class._forName5, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Class;")]
        public static global::java.lang.Class forName(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallStaticObjectMethod(global::java.lang.Class.staticClass, global::java.lang.Class._forName6, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Z")]
        public virtual bool isAssignableFrom(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isAssignableFrom7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool isInstance(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isInstance8, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.Class._getModifiers9);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isInterface() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isInterface10);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isArray() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isArray11);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isPrimitive() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isPrimitive12);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getSuperclass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getSuperclass13));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getComponentType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getComponentType14));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.Class._getName15));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Ljava/lang/Class;")]
        public virtual global::java.lang.Class asSubclass(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._asSubclass16, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object cast(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.lang.Class._cast17, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool desiredAssertionStatus() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._desiredAssertionStatus18);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getCanonicalName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.Class._getCanonicalName19));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/ClassLoader;")]
        public virtual global::java.lang.ClassLoader getClassLoader() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.ClassLoader>(env.CallObjectMethod(this, global::java.lang.Class._getClassLoader20));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getClasses() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Class[])(env.ConvertArrayToNet<java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getClasses21))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;")]
        public virtual global::java.lang.reflect.Constructor getConstructor(java.lang.Class[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Constructor>(env.CallObjectMethod(this, global::java.lang.Class._getConstructor22, global::net.sf.jni4net.jni.Value.CreateArray(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Constructor;")]
        public virtual java.lang.reflect.Constructor[] getConstructors() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Constructor[])(env.ConvertArrayToNet<java.lang.reflect.Constructor>(env.CallObjectMethod(this, global::java.lang.Class._getConstructors23))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getDeclaredClasses() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Class[])(env.ConvertArrayToNet<java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredClasses24))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;")]
        public virtual global::java.lang.reflect.Constructor getDeclaredConstructor(java.lang.Class[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Constructor>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredConstructor25, global::net.sf.jni4net.jni.Value.CreateArray(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Constructor;")]
        public virtual java.lang.reflect.Constructor[] getDeclaredConstructors() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Constructor[])(env.ConvertArrayToNet<java.lang.reflect.Constructor>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredConstructors26))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/reflect/Field;")]
        public virtual global::java.lang.reflect.Field getDeclaredField(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Field>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredField27, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Field;")]
        public virtual java.lang.reflect.Field[] getDeclaredFields() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Field[])(env.ConvertArrayToNet<java.lang.reflect.Field>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredFields28))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;")]
        public virtual global::java.lang.reflect.Method getDeclaredMethod(global::java.lang.String par0, java.lang.Class[] par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Method>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredMethod29, new global::net.sf.jni4net.jni.Value(par0), global::net.sf.jni4net.jni.Value.CreateArray(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Method;")]
        public virtual java.lang.reflect.Method[] getDeclaredMethods() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Method[])(env.ConvertArrayToNet<java.lang.reflect.Method>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaredMethods30))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getDeclaringClass31));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getEnclosingClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getEnclosingClass32));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Constructor;")]
        public virtual global::java.lang.reflect.Constructor getEnclosingConstructor() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Constructor>(env.CallObjectMethod(this, global::java.lang.Class._getEnclosingConstructor33));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Method;")]
        public virtual global::java.lang.reflect.Method getEnclosingMethod() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Method>(env.CallObjectMethod(this, global::java.lang.Class._getEnclosingMethod34));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Object;")]
        public virtual java.lang.Object[] getEnumConstants() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Object[])(env.ConvertArrayToNet<java.lang.Object>(env.CallObjectMethod(this, global::java.lang.Class._getEnumConstants35))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/reflect/Field;")]
        public virtual global::java.lang.reflect.Field getField(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Field>(env.CallObjectMethod(this, global::java.lang.Class._getField36, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Field;")]
        public virtual java.lang.reflect.Field[] getFields() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Field[])(env.ConvertArrayToNet<java.lang.reflect.Field>(env.CallObjectMethod(this, global::java.lang.Class._getFields37))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericInterfaces() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Type[])(env.ConvertArrayToNet<java.lang.reflect.Type>(env.CallObjectMethod(this, global::java.lang.Class._getGenericInterfaces38))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        public virtual global::java.lang.reflect.Type getGenericSuperclass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Type>(env.CallObjectMethod(this, global::java.lang.Class._getGenericSuperclass39));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getInterfaces() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Class[])(env.ConvertArrayToNet<java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Class._getInterfaces40))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;")]
        public virtual global::java.lang.reflect.Method getMethod(global::java.lang.String par0, java.lang.Class[] par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.Method>(env.CallObjectMethod(this, global::java.lang.Class._getMethod41, new global::net.sf.jni4net.jni.Value(par0), global::net.sf.jni4net.jni.Value.CreateArray(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Method;")]
        public virtual java.lang.reflect.Method[] getMethods() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Method[])(env.ConvertArrayToNet<java.lang.reflect.Method>(env.CallObjectMethod(this, global::java.lang.Class._getMethods42))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()LSystem/Object;")]
        public virtual object getPackage() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::java.lang.Class._getPackage43));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()LSystem/Object;")]
        public virtual object getProtectionDomain() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::java.lang.Class._getProtectionDomain44));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/net/URL;")]
        public virtual global::java.net.URL getResource(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.net.URL>(env.CallObjectMethod(this, global::java.lang.Class._getResource45, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/io/InputStream;")]
        public virtual global::java.io.InputStream getResourceAsStream(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.io.InputStream>(env.CallObjectMethod(this, global::java.lang.Class._getResourceAsStream46, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Object;")]
        public virtual java.lang.Object[] getSigners() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Object[])(env.ConvertArrayToNet<java.lang.Object>(env.CallObjectMethod(this, global::java.lang.Class._getSigners47))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getSimpleName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.Class._getSimpleName48));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAnnotation() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isAnnotation49);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAnonymousClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isAnonymousClass50);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isEnum() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isEnum51);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isLocalClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isLocalClass52);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isMemberClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isMemberClass53);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Class._isSynthetic54);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public virtual global::java.lang.Object newInstance() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.lang.Class._newInstance55));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.Class(env);
            }
        }
    }
    #endregion
}