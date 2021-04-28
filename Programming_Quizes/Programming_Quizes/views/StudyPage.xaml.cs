using System;
using System.Threading.Tasks;

using Plugin.TextToSpeech;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programming_Quizes.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudyPage : ContentPage
    {
        public StudyPage()
        {
            InitializeComponent();

            #region AnimationsInit
            Task.WhenAll(
                       CSharpDef.FadeTo(0, 1),
                       definitions.FadeTo(0, 1),
                       progLang.FadeTo(0, 1),
                       OOP.FadeTo(0, 1),
                       DotNETFramework.FadeTo(0, 1),
                       clr.FadeTo(0, 1),
                       cls.FadeTo(0, 1),
                       cts.FadeTo(0, 1),
                       MSIL.FadeTo(0, 1),
                       JIT.FadeTo(0, 1),
                       Compiler.FadeTo(0, 1),
                       SourceCode.FadeTo(0, 1),
                       ExecutableCode.FadeTo(0, 1),
                       boxview1.FadeTo(0, 1),
                       generalProgTerms.FadeTo(0, 1),
                       Variables.FadeTo(0, 1),
                       DataType.FadeTo(0, 1),
                       Keywords.FadeTo(0, 1),
                       Operators.FadeTo(0, 1),
                       Expression.FadeTo(0, 1),
                       TypeCasting.FadeTo(0, 1),
                       Arrays.FadeTo(0, 1),
                       Function.FadeTo(0, 1),
                       Class.FadeTo(0, 1),
                       Object.FadeTo(0, 1),
                       Constructor.FadeTo(0, 1),
                       Destructor.FadeTo(0, 1),
                       Namespaces.FadeTo(0, 1),
                       Exceptions.FadeTo(0, 1),
                       ExceptionHandling.FadeTo(0, 1),
                       boxview2.FadeTo(0, 1),
                       oopProgTerms.FadeTo(0, 1),
                       Inheritance.FadeTo(0, 1),
                       BaseClass.FadeTo(0, 1),
                       DerivedClass.FadeTo(0, 1),
                       AbstractClass.FadeTo(0, 1),
                       MultilevelInheritance.FadeTo(0, 1),
                       HierarchicalInheritance.FadeTo(0, 1),
                       SingleInheritance.FadeTo(0, 1),
                       Interface.FadeTo(0, 1),
                       Polymorphism.FadeTo(0, 1),
                       Overriding.FadeTo(0, 1),
                       Encapsulation.FadeTo(0, 1),
                       Abstraction.FadeTo(0, 1),
                       Overloading.FadeTo(0, 1));
            #endregion


            // App.adCounter = 0;
        }

        protected async override void OnAppearing()
        {
            #region AnimationsFadeIn
            await Task.WhenAll(
                           CSharpDef.FadeTo(1, 500),
                           definitions.FadeTo(1, 500),
                           progLang.FadeTo(1, 500),
                           OOP.FadeTo(1, 500),
                           DotNETFramework.FadeTo(1, 500),
                           clr.FadeTo(1, 500),
                           cls.FadeTo(1, 500),
                           cts.FadeTo(1, 500),
                           MSIL.FadeTo(1, 500),
                           JIT.FadeTo(1, 500),
                           Compiler.FadeTo(1, 500),
                           SourceCode.FadeTo(1, 500),
                           ExecutableCode.FadeTo(1, 500),
                           boxview1.FadeTo(1, 500),
                           generalProgTerms.FadeTo(1, 500),
                           Variables.FadeTo(1, 500),
                           DataType.FadeTo(1, 500),
                           Keywords.FadeTo(1, 500),
                           Operators.FadeTo(1, 500),
                           Expression.FadeTo(1, 500),
                           TypeCasting.FadeTo(1, 500),
                           Arrays.FadeTo(1, 500),
                           Function.FadeTo(1, 500),
                           Class.FadeTo(1, 500),
                           Object.FadeTo(1, 500),
                           Constructor.FadeTo(1, 500),
                           Destructor.FadeTo(1, 500),
                           Namespaces.FadeTo(1, 500),
                           Exceptions.FadeTo(1, 500),
                           ExceptionHandling.FadeTo(1, 500),
                           boxview2.FadeTo(1, 500),
                           oopProgTerms.FadeTo(1, 500),
                           Inheritance.FadeTo(1, 500),
                           BaseClass.FadeTo(1, 500),
                           DerivedClass.FadeTo(1, 500),
                           AbstractClass.FadeTo(1, 500),
                           MultilevelInheritance.FadeTo(1, 500),
                           HierarchicalInheritance.FadeTo(1, 500),
                           SingleInheritance.FadeTo(1, 500),
                           Interface.FadeTo(1, 500),
                           Polymorphism.FadeTo(1, 500),
                           Overriding.FadeTo(1, 500),
                           Encapsulation.FadeTo(1, 500),
                           Abstraction.FadeTo(1, 500),
                           Overloading.FadeTo(1, 500));
            #endregion

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Study.CSharp());
        }

        //private void AdFunc()
        //{
        //    App.adCounter++;
        //    if (App.adCounter == 3)
        //    {
        //        App.adCounter = 0;
        //        Navigation.PushModalAsync(new Controls.AdViewPage());
        //    }
        //}
        // Definitions
        private void progLang_Clicked(object sender, EventArgs e)
        {
            string phrase = "A programming language is a language which is used" +
                " to write instructions that are executed by a machine ";

            DisplayAlert("Programming Language", phrase + "(computer)", "Alright");


            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void OOP_Clicked(object sender, EventArgs e)
        {
            string phrase = "Object-oriented programming (OOP) is a programming " +
                "paradigm based on the concept of \"objects\", which can contain data and code: " +
                "data in the form of fields (often known as attributes or properties), and code, " +
                "in the form of procedures (often known as methods).";

            DisplayAlert("OOP", phrase, "Alright");


            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void DotNETFramework_Clicked(object sender, EventArgs e)
        {
            string phrase = "NET Framework In easy words, it is a virtual machine " +
                "for compiling and executing programs written in different languages like C#, VB.Net" +
                " etc.";

            DisplayAlert(".NET Framework", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void clr_Clicked(object sender, EventArgs e)
        {
            string phrase = "CLR stands for Common Language Runtime. It is the core of the" +
                " .NET Framework. CLR is the runtime environment (the virtual machine) which is" +
                " responsible for the execution of all programs runned under .NET Framework. For" +
                " example C#, VB.NET programs.";

            DisplayAlert("CLR", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void cls_Clicked(object sender, EventArgs e)
        {
            string phrase = "CLS stands for Common Language Specification and it is a subset of" +
                " the CTS (Common Type System). It defines the set of rules which every language should follow. ";

            DisplayAlert("CLS", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void cts_Clicked(object sender, EventArgs e)
        {
            string phrase = "CTS stands for Common Type System. The Common Type System (CTS) " +
                " describes the datatypes that can be used by managed code. CTS defines" +
                " how these types are declared, used and managed in the runtime. ";

            DisplayAlert("CTS", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void MSIL_Clicked(object sender, EventArgs e)
        {
            string phrase = "MSIL or just IL stands for Microsoft Intermediate Language. " +
                "It is also known as CIL (Common Intermediate Language) and it is a CPU-independent " +
                "set of instructions that can be efficiently converted to the native code. " +
                "Firstly during the compilation, the compiler converts the source code into " +
                "Intermediate Language and then the JIT Compiler Converts the IL code to native code " +
                "(machine code).";

            DisplayAlert("MSIL", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void JIT_Clicked(object sender, EventArgs e)
        {
            string phrase = "JIT stands for Just-in-Time compiler and it is responsible for the " +
                "conversion of IL code into machine code.";

            DisplayAlert("JIT", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Compiler_Clicked(object sender, EventArgs e)
        {
            string phrase = "The C# Compiler is a module which translates/converts the " +
                "source code of a given program into Intermediate Language (IL) code.";

            DisplayAlert("C# Compiler", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void SourceCode_Clicked(object sender, EventArgs e)
        {
            string phrase = "Source code is the code which is written by the programmer " +
                "in a human readable form with all the proper programming syntaxes and restrictions.";

            DisplayAlert("Source Code", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void ExecutableCode_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Executable code is the machine understandable code, " +
                "which can be executed by the machine.";

            DisplayAlert("Executable code", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }




        // General Programming Terms
        private void Variables_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Variable is a memory-location in the memory of the program " +
                "which is used to store information. The values stored in a variable can be changed " +
                "during the program's execution.";

            DisplayAlert("Variables", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void DataType_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Data Type gives information about what information can be " +
                "stored in a given variable (for example an int variable can store whole numbers, a string " +
                "value can store a set of characters and so on).";

            DisplayAlert("Data Type", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Keywords_Clicked(object sender, EventArgs e)
        {
            string phrase = "The keywords are the words whose meaning is already known to the compiler. " +
                "For example all the words for defining a data type like int or a string or the keyword " +
                "void used in the declaration of methods, and many more.";

            DisplayAlert("Keywords", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Operators_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Operators are the symbols which we use to" +
                " perform certain operations on operands like division, substraction, etc.";

            DisplayAlert("Operators", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Expression_Clicked(object sender, EventArgs e)
        {
            string phrase = "A statement which has valid operators and operands sequance is known as an expression.";

            DisplayAlert("Expression", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void TypeCasting_Clicked(object sender, EventArgs e)
        {
            string phrase = "Type-Casting is the process of converting a variable's content from " +
                "one data type to another. For example converting from int to a float data type.";

            DisplayAlert("Type-Casting", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Arrays_Clicked(object sender, EventArgs e)
        {
            string phrase = "The array is a collection of variables having the same data-type";

            DisplayAlert("Arrays", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Function_Clicked(object sender, EventArgs e)
        {
            string phrase = "Functions are also known as methods, they are a group of instructions which performs a predefined task.";

            DisplayAlert("Functions", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Class_Clicked(object sender, EventArgs e)
        {
            string phrase = "A class is like a blueprint of a specific object. A class " +
                "defines the kinds of data and the functionality their objects will have. " +
                "... A class enables you to create your custom types by grouping variables " +
                "of other types, methods, and events. In C#, a class can be defined by using the class keyword.";

            DisplayAlert("Class", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Object_Clicked(object sender, EventArgs e)
        {
            string phrase = "In C#, Object is a real world entity, for example, chair, car," +
                " pen, mobile, laptop etc. In other words, object is an entity that has state" +
                " and behavior. Here, state means data and behavior means functionality. " +
                "Object is a runtime entity, it is created at runtime.";

            DisplayAlert("Object", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Constructor_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Constructor is a special member function that has the" +
                " same name as the class. It is used for the automatic initialization of" +
                " objects of the class. It is automatically called whenever an object of" +
                " its class is created.If there is no defined constructor in a class, the" +
                " class creates its default constructor in the background.";

            DisplayAlert("Constructor", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Destructor_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Destructor is a special member function that has the same" +
                " name as the class. It is created with a (~) symbol. It is used to destroy " +
                "the already created objects by the constructor.";

            DisplayAlert("Destructor", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Namespaces_Clicked(object sender, EventArgs e)
        {
            string phrase = "The namespaces provide you with a \"Space\" in which you can " +
                "organize your application's classes. It is used to separate one set of classes from another.";

            DisplayAlert("Namespace", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Exceptions_Clicked(object sender, EventArgs e)
        {
            string phrase = "The exception is a Runtime Error that occurs whenever an error is thrown from the program at Runtime.";

            DisplayAlert("Exception", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void ExceptionHandling_Clicked(object sender, EventArgs e)
        {
            string phrase = "Exception Handling is the process of handling runtime-errors (exceptions).";

            DisplayAlert("Exception Handling", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }



        // Object-Oriented Programming Terms
        private void Inheritance_Clicked(object sender, EventArgs e)
        {
            string phrase = "In C#, it is possible to inherit fields and methods from one class to" +
                " another. We group the \"inheritance concept\" into two categories: \n" +
                "Derived Class(child) - the class that inherits from another class \n" +
                "Base Class(parent) - the class being inherited from";

            DisplayAlert("Inheritance", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void BaseClass_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Base Class refers to the class that the derived class inherits fields and methods from.";

            DisplayAlert("Base Class", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void DerivedClass_Clicked(object sender, EventArgs e)
        {
            string phrase = "The Derived Class is the class that inherits from the Base Class.";

            DisplayAlert("Derived Class", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);

        }

        private void AbstractClass_Clicked(object sender, EventArgs e)
        {
            string phrase = "Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).";

            DisplayAlert("Abstract Class", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void MultilevelInheritance_Clicked(object sender, EventArgs e)
        {
            string phrase = "In the Multilevel inheritance, a derived class will inherit " +
                "a base class and as well as the derived class also act as the base class to other class.";

            DisplayAlert("Multilevel Inheritance", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void HierarchicalInheritance_Clicked(object sender, EventArgs e)
        {
            string phrase = "By Hierarchical Inheritance we say that more than one class is inherited from the base class.";

            DisplayAlert("Hierarchical Inheritance", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void SingleInheritance_Clicked(object sender, EventArgs e)
        {
            string phrase = "Single Inheritance means that there is ONLY ONE class that derives from the base class.";

            DisplayAlert("Single Inheritance", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Interface_Clicked(object sender, EventArgs e)
        {
            string phrase = "An interface is an abstract class, which can only contain abstract" +
                " methods and properties (without their implementation).";

            DisplayAlert("Interface", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Polymorphism_Clicked(object sender, EventArgs e)
        {
            string phrase = "Polymorphism means \"many forms\", and it occurs when we have " +
                "many classes that are related to each other by inheritance. Inheritance lets" +
                " us inherit fields and methods from another class. Polymorphism uses those " +
                "methods to perform different tasks.This allows us to perform a single action in different ways."; 

            DisplayAlert("Polymorphism", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }
        private void Overriding_Clicked(object sender, EventArgs e)
        {
            string phrase = "Method Overriding is a technique that allows the invoking of " +
                "functions from another class (base class) in the derived class. Creating " +
                "a method in the derived class with the same signature as a method in the " +
                "base class is called as method overriding.";

            DisplayAlert("Overriding", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }

        private void Encapsulation_Clicked(object sender, EventArgs e)
        {
            string phrase = "Abstraction and encapsulation are related features in object oriented programming. " +
                "Abstraction allows making relevant information visible and encapsulation enables a programmer to " +
                "implement the desired level of abstraction. \n" +
                "Encapsulation is implemented by using access specifiers." +
                " An access specifier defines the scope and visibility of a class member." +
                " C# supports the following access specifiers − \n" +
                "Public \n" +
                "Private \n" +
                "Protected \n" +
                "Internal \n" +
                "Protected internal \n";

            DisplayAlert("Encapsulation", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }
        private void Abstraction_Clicked(object sender, EventArgs e)
        {
            string phrase = "Abstraction and encapsulation are related features in object" +
                " oriented programming. Abstraction allows making relevant information" +
                " visible and encapsulation enables a programmer to implement the desired level of abstraction.";

            DisplayAlert("Abstraction", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }
        private void Overloading_Clicked(object sender, EventArgs e)
        {
            string phrase = "Method Overloading is the common way of implementing polymorphism." +
                " It is the ability to redefine a function in more than one form. A user can " +
                "implement function overloading by defining two or more functions in a class sharing the same name.";

            DisplayAlert("Overloading", phrase, "Alright");

            CrossTextToSpeech.Current.Speak(phrase);
        }
    }
}