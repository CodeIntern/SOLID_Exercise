using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesCoding
{
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

    public class MainClass
    {
        static void Main()
        {
            return;
        }
    }
}
