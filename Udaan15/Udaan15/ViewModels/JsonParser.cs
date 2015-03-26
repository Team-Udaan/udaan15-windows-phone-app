using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Udaan15.ViewModels;
using Udaan_15.ViewModels;
using System.Windows;

namespace Udaan15.ViewModels
{
    public class JsonParser
    {
        public Cultural getNights(string jsonString)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject<Cultural>(jsonString);
                return obj;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public DeptList getDepartments(string jsonString)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject<DeptList>(jsonString);
                foreach (var item in obj.ListOfDepartments)
                {
                    if(item.name.Contains('-'))
                    {
                        item.name = item.name.Replace('-', ' ');
                    }
                }
                return obj;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public NonTechEvents getNTEvents(string jsonString)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject<NonTechEvents>(jsonString);
                foreach (var item in obj.NTList)
                {
                    if(item.name.Contains('-'))
                    {
                        item.name = item.name.Replace('-', ' ');
                    }
                }
                return obj;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public DeptEventList getTEvents(string jsonString)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject<DeptEventList>(jsonString);
                foreach (var item in obj.DEList)
                {
                    if (item.name.Contains('-'))
                    {
                        item.name = item.name.Replace('-', ' ');
                    }
                }
                return obj;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}
