namespace PhotoBook
{
    internal class PhotoBookTest : BigPhotoBook
    {

        public static string Test()
        {
            int firstT = new PhotoBook().GetNumberPages();
            int secondT = new PhotoBook(24).GetNumberPages();
            int thirdT = new BigPhotoBook().GetNumberPages();

            return $"Test 1:   Book with {firstT}  pages created.\n" +
                    $"Test 2:   Book with {secondT} pages created.\n" +
                    $"Test 3:   Book with {thirdT}  pages created.\n";
        }
    }
}
