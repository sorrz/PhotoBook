namespace PhotoBook
{
    class PhotoBook
    {

        private int numPages;

        protected int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }


        // Out standard constructor, sets the number of pages to 16
        public PhotoBook()
        {
            numPages = 16;
        }


        // Constructor to take valid input from user to create a custome size PhotoBook
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;


        }




        // Using GetNumberPages to return the current value
        public int GetNumberPages()
        {

            return numPages;

        }

    }
}
