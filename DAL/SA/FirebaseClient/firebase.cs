using BE;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SA.FirebaseClient
{
    public class firebase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static async Task<string> addToFirebaseAsync(string filePath)
        {
            var stream = File.Open(filePath, FileMode.Open);

            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage("gs://projectwinterdb.appspot.com/")
             .Child(filePath)
             .PutAsync(stream);

            // Track progress of the upload
            //task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");

            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            return downloadUrl;
        }

    }
}