namespace VisualStudioTips
{
    public class CodeSnippets
    {
        // Put the cursor here and type "ctor" and then press the Tab. This will create a constructor for this class.

        public CodeSnippets()
        {

        }



        // Now put the cursor here and type "prop" and then press the Tab. This will create an auto-implemented property.
        // Note that the "type" is highlighted. Type in "string" and press the Tab. Now you can type a name for this property.
        // Then press the Tab or Enter to finish editing. 

        public int age { get; set; }
        private string name;

        // Now type "propfull" to create a property with a private field. Press the tab and specify the values accordingly.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public void Start()
        {
            int length = 10;

            // Put the cursor here and type "for" and press the Tab. 
            for (int i = 0; i < length; i++)
            { }

            // Do the same with "foreach".
            //foreach (var item in collection)
            //{

            //}

            // Now type "try" to create a try/catch block.

            try
            {

            }
            catch (System.Exception)
            {
                throw;
            }

            // Repeat with "tryf" to create a try/finally block.
            try
            {

            }
            finally
            {

            }


            // Now create a for loop with "for".
            for (int i = length - 1; i >= 0; i--)
            {

            }


            // Or a for loop that decrements the loop variable using "forr".

        }
    }
}
