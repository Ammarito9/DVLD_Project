using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BLL
{
    public class Util
    {
        public static bool CreateFolder(string destinationFolderPath)
        {
            if(Directory.Exists(destinationFolderPath))
                return true;

            try
            {
                Directory.CreateDirectory(destinationFolderPath);
            }
            catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        public static string ReplaceFileNameWithGUID(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return Guid.NewGuid().ToString() + fileInfo.Extension;
        }
        public static bool CopyImageToProjectImageFolder(ref string sourceImagePath)
        {
            string destinationFolderPath = @"D:\DVLD_Images\";
            if(!CreateFolder(destinationFolderPath))
                return false;

            string destinationImagePath = destinationFolderPath + ReplaceFileNameWithGUID(sourceImagePath);
            try
            {
                File.Copy(sourceImagePath, destinationImagePath, true);
            }
            catch (IOException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            sourceImagePath = destinationImagePath;
            return true;
        }
    }
}
