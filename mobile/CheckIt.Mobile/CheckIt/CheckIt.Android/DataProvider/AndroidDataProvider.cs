using CheckIt.Common.DataProvider;
using CheckIt.Droid.DataProvider;
using System;
using System.IO;
using Xamarin.Forms;
using CheckIt.Common.Constants;

[assembly: Dependency(typeof(AndroidDataProvider))]
namespace CheckIt.Droid.DataProvider
{
    public class AndroidDataProvider : IDataProvider
    {
        public string GetPath(string database = Constants.DB_NAME)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), database);
        }
    }
}