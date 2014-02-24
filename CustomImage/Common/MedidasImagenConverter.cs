namespace CustomImage.Common
{
    using System;
    using Windows.Storage.FileProperties;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media.Imaging;
    class MedidasImagenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            BitmapImage myBitmapImage = value as BitmapImage;
            string myuri = myBitmapImage.UriSource.ToString();
            char[] separator = new char[] { '_' };
            string[] measures = myuri.Split(separator, StringSplitOptions.None);
            double width = 310.0;      
            if (measures.Length > 1) {
                double oWidth = double.Parse(measures[1], System.Globalization.CultureInfo.InvariantCulture);
                double oHeigth = double.Parse(measures[2], System.Globalization.CultureInfo.InvariantCulture);
                if (oHeigth > oWidth)
                {
                    width = 193.0;
                }
            }                
            
            return (width);
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
          throw new NotImplementedException();
        }

        
  }
}
