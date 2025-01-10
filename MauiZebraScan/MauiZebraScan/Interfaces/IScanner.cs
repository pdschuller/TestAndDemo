using System;
using MauiZebraScan.Models;

namespace MauiZebraScan.Interfaces
{
    /// <summary>
    /// This is the interface for the Scanner code. This is only implemented natively on an
    /// Android device so we have to use Xamarin Forms Dependency Service to implement this.
    /// This interface defines how we use the Scanner, a matching class needs to be implemented
    /// on each platform as well. The link here incldues a fulld description of the structure.
    /// https://developer.xamarin.com/guides/xamarin-forms/dependency-service/introduction/
    /// </summary>
    public interface IScanner_Android
    {
        event EventHandler<StatusEventArgs> OnScanDataCollected;
        event EventHandler<string> OnStatusChanged;
        // event EventHandler<hard>
        void Read();
        void Enable();
        // enable DCP

        void Disable();
        // NOTE: pds, the Set___ methods are implemented in Platform Scanner_Android.cs
        void SetConfig(IScannerConfig a_config);
        void SetPhotoConfig(IScannerConfig a_config);
        // void Set2dConfig(IScannerConfig a_config);
        // void SetDataMatrixConfig(IScannerConfig a_config);
        // SetConfigFromIScannerConfig
        // void SetConfigFromIScannerConfig(IScannerConfig a_config);
    }
}
