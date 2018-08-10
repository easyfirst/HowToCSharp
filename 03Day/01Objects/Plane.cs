namespace _01Objects
{
    public class Plane
    {
        public Plane()
        {
        }

        // State
        //  * * * field : * * *
        // It is like property of object
        private int NrOfNodes;

        // It contans the number of edge of plane
        // It is possible to read and write from outside of instance.
        // It is not recommended to use.
        public int NrOfEdge;




        // * * * property : * * *
        // This is the same as field if you use (choose) the default mode.
        public int NrOfArcs { get; set; }
        // The builder make a code of it like this:
        // eparate the reading and writing of property.

        /// <summary>
        /// Backing field, it contains the value of property
        /// </summary>
        private int _nrOfArcs;

        /// <summary>
        /// Getter function. It returns with the value of property.
        /// </summary>
        /// <returns>value of property</returns>
        public int NrOfArcs_GET()
        {
            return _nrOfArcs;
        }

        /// <summary>
        /// Setter. It sets the value of property.
        /// </summary>
        /// <param name="value">The new value to set for property</param>
        public void NrOfArcs_SET(int value)
        {
            _nrOfArcs = value;
        }



        // Conclusion:

        // 1, We could handle separate getting and setting.
        // It is read only:
        public int Data1 { get; }   // default format

        // It is write only. It must be implemented !:
        // Incomming argument name is "value", it's type is the same as the type of property.
        private int _data2;
        public int Data2 { set { _data2 = value; } }   // NOT default format. It contains implementation.

        //2, It can be separately controlled to set for reading and writing.
        // The property is possible to read only from internal. The property is possible to write from internal and external too.
        public int Date3 { private get; set; }  // default format
        // The property is possible to read from internal and external too. The property is possible to write only internal.
        public int Data4 { get; private set; }  // default format

        //3, The builder make a default getter and setter without implementation.

        //4, If we want set an implementation:
        // It's necessary to use a backing field.
        private string _name;
        public string Name {
            get {
                // do hire some code

                // at the end return with the value
                return _name;
            }

            set {
                // do hire some code
                // "value" argument is usable hire

                // at the end set the value
                _name = value;

            }
        }

        // Behaviour
        // Controling (regulating) with functions
        // Signature: name + argument's type
        // function overloading
        public void Show(bool disable)
        {

        }
        // or
        public void Show(int posX, int posY)
        {

        }

        // Possible argument types:
        // *** Default ***
        // if the argument behaves like valu type , argument passing behaves as value passing.
        // if the argument behaves like reference type , argument passing behaves as reference passing.
        // if we want to pass valu type argument as reference, then we have to sign it with "ref" keyword
        // if the out argument is accessed, it has to get a value in the function.
        public void Show(int height, ReferenceType reference, ref int width, out int value3)
        {
            // if the out argument is accessed, it has to get a value in the function.
            value3 = 10;

            System.Console.WriteLine($"Show height: {height} , reference.value: {reference.value} , width: {width} , value3: {value3}");

            height = height * 2;
            reference.value = reference.value * 2;
            width *= 2;

            System.Console.WriteLine($"Show height: {height} , reference.value: {reference.value} , width: {width} , value3: {value3}");
        }

        // Parameters for functions can be set to default values.
        public void Show(int height = 5, int width = 10, string name = "NAME")
        {
            System.Console.WriteLine("Arguments with default value:");
            System.Console.WriteLine($"Show height: {height} , width: {width} , name: {name}");
        }

    }
}