using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Separating the Classes, Interfaces, and Implementations into different files would've been the better choice, but 
 * because this is such a small concept program I just threw it all in a single file
*/

namespace InterfacesCoding
{
    /*
     * Interfaces that declares which functions are necessary to be able to use the phones' features
    */

    interface I720pCameraCompatible
    {
        void Add720pImage();
    }

    interface I4kCameraCompatible
    {
        void Add4kImage();
    }

    interface IUSOutletCompatible
    {
        void GetUSCharge();
    }

    interface IEUOutletCompatible
    {
        void GetEUCharge();
    }

    //Class representing a phone product, the iPhone
    public class iPhone : I720pCameraCompatible, IUSOutletCompatible
    {
        void I720pCameraCompatible.Add720pImage()
        {
            //Code that adds a 720p image to the phone
        }

        void IUSOutletCompatible.GetUSCharge()
        {
            //Code that increases a phone's charge with us type outlets
        }
    }

    //Class representing a Nokia phone
    public class Nokia : I4kCameraCompatible, IEUOutletCompatible
    {
        void I4kCameraCompatible.Add4kImage()
        {
            //Code that adds a 4k image to the phone
        }

        void IEUOutletCompatible.GetEUCharge()
        {
            //Code that includes how this increases its charge
        }
    }

    /*
        * For the PhoneCharger and CameraActivator classes, I decided to use the overloading route
        * so that users wouldn't have to constantly remember what outlet or camera the phone uses
    */

    //Class that deals with the details of operating a certain type of electrical outlet
    public class PhoneCharger
    {
        static void ChargePhone(IUSOutletCompatible usPhone)
        {
            //Code that deals with connecting to a us outlet
            usPhone.GetUSCharge();
        }

        static void ChargePhone(IEUOutletCompatible euPhone)
        {
            //Code that deals with connecting to a eu outlet
            euPhone.GetEUCharge();
        }
    }

    //Class that deals with the work details of operating a type of camera
    public class CameraActivator
    {
        static void TakePicture(I720pCameraCompatible camera720p)
        {
            //Code that deals with processing 720p images
            camera720p.Add720pImage();
        }

        static void TakePicture(I4kCameraCompatible camera4k)
        {
            //Code that deals with processing 4k images
            camera4k.Add4kImage();
        }
    }

    //Added a main out of habit, not relevant
    /*
    public class MainClass
    {
        static void Main()
        {
            return;
        }
    }
    */
}
