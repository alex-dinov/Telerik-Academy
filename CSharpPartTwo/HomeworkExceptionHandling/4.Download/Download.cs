/*Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 * and stores it the current directory. Find in Google how to download files in C#.
 * Be sure to catch all exceptions and to free any used resources in the finally block.
*/
using System;
using System.Net;

class Download
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
            }

            catch(ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }

            catch (WebException)
            {
                Console.WriteLine(@"The URI formed by combining BaseAddress and address is invalid.
                                    -or-
                                    filename is null or Empty.
                                    -or-
                                    The file does not exist.
                                    -or- An error occurred while downloading data.");
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}

