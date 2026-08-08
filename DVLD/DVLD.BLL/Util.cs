using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DAL;

namespace DVLD.BLL
{
    public class Util
    {
        public static void WriteToRegistry(string keyName, string valueName, object valueData, RegistryValueKind registryValueKind)
        {
            try
            {
                Registry.SetValue(keyName, valueName, valueData, registryValueKind);
            }
            catch (ArgumentException ex)
            {
                throw(ex);
            }
            catch (NullReferenceException ex)
            {
                throw (ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public static object? ReadFromRegistry(string keyName, string valueName)
        {
            try
            {
                return Registry.GetValue(keyName, valueName, null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public static void StoreUserCredentialsToRegistry(string username, string password)
        {
            string[] userCredentials = { username, password };

            WriteToRegistry(Connection.RegistryKeyName, "User Credentials", String.Join("#//#", userCredentials), RegistryValueKind.String);
        }
        /// <summary>
        /// It reads the user credentials from a registry.
        /// </summary>
        /// <returns>If found it returns an array first index is username and second is password; other ways null</returns>
        public static string[]? GetUserCredentialsFromRegistry()
        {
            object? obj = ReadFromRegistry(Connection.RegistryKeyName, "User Credentials");

            if(obj is null)
                return null;

            string[] userCredentials = (obj as string).Split("#//#");

            return userCredentials;
        }
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
