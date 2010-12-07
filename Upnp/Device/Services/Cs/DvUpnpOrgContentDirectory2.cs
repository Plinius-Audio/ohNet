using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp.Device.Providers
{
    public interface IDvProviderUpnpOrgContentDirectory2 : IDisposable
    {

        /// <summary>
        /// Set the value of the SystemUpdateID property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertySystemUpdateID(uint aValue);

        /// <summary>
        /// Get a copy of the value of the SystemUpdateID property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        void GetPropertySystemUpdateID(out uint aValue);

        /// <summary>
        /// Set the value of the ContainerUpdateIDs property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyContainerUpdateIDs(string aValue);

        /// <summary>
        /// Get a copy of the value of the ContainerUpdateIDs property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        void GetPropertyContainerUpdateIDs(out string aValue);

        /// <summary>
        /// Set the value of the TransferIDs property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyTransferIDs(string aValue);

        /// <summary>
        /// Get a copy of the value of the TransferIDs property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        void GetPropertyTransferIDs(out string aValue);
        
    }
    /// <summary>
    /// Provider for the upnp.org:ContentDirectory:2 UPnP service
    /// </summary>
    public class DvProviderUpnpOrgContentDirectory2 : DvProvider, IDisposable, IDvProviderUpnpOrgContentDirectory2
    {
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern IntPtr DvProviderUpnpOrgContentDirectory2Create(IntPtr aDeviceHandle);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2Destroy(IntPtr aHandle);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern unsafe int DvProviderUpnpOrgContentDirectory2SetPropertySystemUpdateID(IntPtr aHandle, uint aValue, uint* aChanged);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern unsafe void DvProviderUpnpOrgContentDirectory2GetPropertySystemUpdateID(IntPtr aHandle, uint* aValue);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern unsafe int DvProviderUpnpOrgContentDirectory2SetPropertyContainerUpdateIDs(IntPtr aHandle, char* aValue, uint* aChanged);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern unsafe void DvProviderUpnpOrgContentDirectory2GetPropertyContainerUpdateIDs(IntPtr aHandle, char** aValue);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern unsafe int DvProviderUpnpOrgContentDirectory2SetPropertyTransferIDs(IntPtr aHandle, char* aValue, uint* aChanged);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern unsafe void DvProviderUpnpOrgContentDirectory2GetPropertyTransferIDs(IntPtr aHandle, char** aValue);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionGetSearchCapabilities(IntPtr aHandle, CallbackGetSearchCapabilities aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionGetSortCapabilities(IntPtr aHandle, CallbackGetSortCapabilities aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionGetSortExtensionCapabilities(IntPtr aHandle, CallbackGetSortExtensionCapabilities aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionGetFeatureList(IntPtr aHandle, CallbackGetFeatureList aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionGetSystemUpdateID(IntPtr aHandle, CallbackGetSystemUpdateID aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionBrowse(IntPtr aHandle, CallbackBrowse aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionSearch(IntPtr aHandle, CallbackSearch aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionCreateObject(IntPtr aHandle, CallbackCreateObject aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionDestroyObject(IntPtr aHandle, CallbackDestroyObject aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionUpdateObject(IntPtr aHandle, CallbackUpdateObject aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionMoveObject(IntPtr aHandle, CallbackMoveObject aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionImportResource(IntPtr aHandle, CallbackImportResource aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionExportResource(IntPtr aHandle, CallbackExportResource aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionDeleteResource(IntPtr aHandle, CallbackDeleteResource aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionStopTransferResource(IntPtr aHandle, CallbackStopTransferResource aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionGetTransferProgress(IntPtr aHandle, CallbackGetTransferProgress aCallback, IntPtr aPtr);
        [DllImport("DvUpnpOrgContentDirectory2")]
        static extern void DvProviderUpnpOrgContentDirectory2EnableActionCreateReference(IntPtr aHandle, CallbackCreateReference aCallback, IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private unsafe delegate int CallbackGetSearchCapabilities(IntPtr aPtr, uint aVersion, char** aSearchCaps);
        private unsafe delegate int CallbackGetSortCapabilities(IntPtr aPtr, uint aVersion, char** aSortCaps);
        private unsafe delegate int CallbackGetSortExtensionCapabilities(IntPtr aPtr, uint aVersion, char** aSortExtensionCaps);
        private unsafe delegate int CallbackGetFeatureList(IntPtr aPtr, uint aVersion, char** aFeatureList);
        private unsafe delegate int CallbackGetSystemUpdateID(IntPtr aPtr, uint aVersion, uint* aId);
        private unsafe delegate int CallbackBrowse(IntPtr aPtr, uint aVersion, char* aObjectID, char* aBrowseFlag, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID);
        private unsafe delegate int CallbackSearch(IntPtr aPtr, uint aVersion, char* aContainerID, char* aSearchCriteria, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID);
        private unsafe delegate int CallbackCreateObject(IntPtr aPtr, uint aVersion, char* aContainerID, char* aElements, char** aObjectID, char** aResult);
        private unsafe delegate int CallbackDestroyObject(IntPtr aPtr, uint aVersion, char* aObjectID);
        private unsafe delegate int CallbackUpdateObject(IntPtr aPtr, uint aVersion, char* aObjectID, char* aCurrentTagValue, char* aNewTagValue);
        private unsafe delegate int CallbackMoveObject(IntPtr aPtr, uint aVersion, char* aObjectID, char* aNewParentID, char** aNewObjectID);
        private unsafe delegate int CallbackImportResource(IntPtr aPtr, uint aVersion, char* aSourceURI, char* aDestinationURI, uint* aTransferID);
        private unsafe delegate int CallbackExportResource(IntPtr aPtr, uint aVersion, char* aSourceURI, char* aDestinationURI, uint* aTransferID);
        private unsafe delegate int CallbackDeleteResource(IntPtr aPtr, uint aVersion, char* aResourceURI);
        private unsafe delegate int CallbackStopTransferResource(IntPtr aPtr, uint aVersion, uint aTransferID);
        private unsafe delegate int CallbackGetTransferProgress(IntPtr aPtr, uint aVersion, uint aTransferID, char** aTransferStatus, char** aTransferLength, char** aTransferTotal);
        private unsafe delegate int CallbackCreateReference(IntPtr aPtr, uint aVersion, char* aContainerID, char* aObjectID, char** aNewID);

        private GCHandle iGch;
        private CallbackGetSearchCapabilities iCallbackGetSearchCapabilities;
        private CallbackGetSortCapabilities iCallbackGetSortCapabilities;
        private CallbackGetSortExtensionCapabilities iCallbackGetSortExtensionCapabilities;
        private CallbackGetFeatureList iCallbackGetFeatureList;
        private CallbackGetSystemUpdateID iCallbackGetSystemUpdateID;
        private CallbackBrowse iCallbackBrowse;
        private CallbackSearch iCallbackSearch;
        private CallbackCreateObject iCallbackCreateObject;
        private CallbackDestroyObject iCallbackDestroyObject;
        private CallbackUpdateObject iCallbackUpdateObject;
        private CallbackMoveObject iCallbackMoveObject;
        private CallbackImportResource iCallbackImportResource;
        private CallbackExportResource iCallbackExportResource;
        private CallbackDeleteResource iCallbackDeleteResource;
        private CallbackStopTransferResource iCallbackStopTransferResource;
        private CallbackGetTransferProgress iCallbackGetTransferProgress;
        private CallbackCreateReference iCallbackCreateReference;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aDevice">Device which owns this provider</param>
        protected DvProviderUpnpOrgContentDirectory2(DvDevice aDevice)
        {
            iHandle = DvProviderUpnpOrgContentDirectory2Create(aDevice.Handle()); 
            iGch = GCHandle.Alloc(this);
        }

        /// <summary>
        /// Set the value of the SystemUpdateID property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public unsafe bool SetPropertySystemUpdateID(uint aValue)
        {
            uint changed;
            if (0 != DvProviderUpnpOrgContentDirectory2SetPropertySystemUpdateID(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        /// <summary>
        /// Get a copy of the value of the SystemUpdateID property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        public unsafe void GetPropertySystemUpdateID(out uint aValue)
        {
            fixed (uint* value = &aValue)
            {
                DvProviderUpnpOrgContentDirectory2GetPropertySystemUpdateID(iHandle, value);
            }
        }

        /// <summary>
        /// Set the value of the ContainerUpdateIDs property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public unsafe bool SetPropertyContainerUpdateIDs(string aValue)
        {
            uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderUpnpOrgContentDirectory2SetPropertyContainerUpdateIDs(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        /// <summary>
        /// Get a copy of the value of the ContainerUpdateIDs property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        public unsafe void GetPropertyContainerUpdateIDs(out string aValue)
        {
            char* value;
            DvProviderUpnpOrgContentDirectory2GetPropertyContainerUpdateIDs(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        /// <summary>
        /// Set the value of the TransferIDs property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public unsafe bool SetPropertyTransferIDs(string aValue)
        {
            uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderUpnpOrgContentDirectory2SetPropertyTransferIDs(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        /// <summary>
        /// Get a copy of the value of the TransferIDs property
        /// </summary>
        /// <param name="aValue">Property's value will be copied here</param>
        public unsafe void GetPropertyTransferIDs(out string aValue)
        {
            char* value;
            DvProviderUpnpOrgContentDirectory2GetPropertyTransferIDs(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        /// <summary>
        /// Signal that the action GetSearchCapabilities is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoGetSearchCapabilities must be overridden if this is called.</remarks>
        protected unsafe void EnableActionGetSearchCapabilities()
        {
            iCallbackGetSearchCapabilities = new CallbackGetSearchCapabilities(DoGetSearchCapabilities);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionGetSearchCapabilities(iHandle, iCallbackGetSearchCapabilities, ptr);
        }

        /// <summary>
        /// Signal that the action GetSortCapabilities is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoGetSortCapabilities must be overridden if this is called.</remarks>
        protected unsafe void EnableActionGetSortCapabilities()
        {
            iCallbackGetSortCapabilities = new CallbackGetSortCapabilities(DoGetSortCapabilities);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionGetSortCapabilities(iHandle, iCallbackGetSortCapabilities, ptr);
        }

        /// <summary>
        /// Signal that the action GetSortExtensionCapabilities is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoGetSortExtensionCapabilities must be overridden if this is called.</remarks>
        protected unsafe void EnableActionGetSortExtensionCapabilities()
        {
            iCallbackGetSortExtensionCapabilities = new CallbackGetSortExtensionCapabilities(DoGetSortExtensionCapabilities);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionGetSortExtensionCapabilities(iHandle, iCallbackGetSortExtensionCapabilities, ptr);
        }

        /// <summary>
        /// Signal that the action GetFeatureList is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoGetFeatureList must be overridden if this is called.</remarks>
        protected unsafe void EnableActionGetFeatureList()
        {
            iCallbackGetFeatureList = new CallbackGetFeatureList(DoGetFeatureList);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionGetFeatureList(iHandle, iCallbackGetFeatureList, ptr);
        }

        /// <summary>
        /// Signal that the action GetSystemUpdateID is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoGetSystemUpdateID must be overridden if this is called.</remarks>
        protected unsafe void EnableActionGetSystemUpdateID()
        {
            iCallbackGetSystemUpdateID = new CallbackGetSystemUpdateID(DoGetSystemUpdateID);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionGetSystemUpdateID(iHandle, iCallbackGetSystemUpdateID, ptr);
        }

        /// <summary>
        /// Signal that the action Browse is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoBrowse must be overridden if this is called.</remarks>
        protected unsafe void EnableActionBrowse()
        {
            iCallbackBrowse = new CallbackBrowse(DoBrowse);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionBrowse(iHandle, iCallbackBrowse, ptr);
        }

        /// <summary>
        /// Signal that the action Search is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoSearch must be overridden if this is called.</remarks>
        protected unsafe void EnableActionSearch()
        {
            iCallbackSearch = new CallbackSearch(DoSearch);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionSearch(iHandle, iCallbackSearch, ptr);
        }

        /// <summary>
        /// Signal that the action CreateObject is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoCreateObject must be overridden if this is called.</remarks>
        protected unsafe void EnableActionCreateObject()
        {
            iCallbackCreateObject = new CallbackCreateObject(DoCreateObject);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionCreateObject(iHandle, iCallbackCreateObject, ptr);
        }

        /// <summary>
        /// Signal that the action DestroyObject is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoDestroyObject must be overridden if this is called.</remarks>
        protected unsafe void EnableActionDestroyObject()
        {
            iCallbackDestroyObject = new CallbackDestroyObject(DoDestroyObject);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionDestroyObject(iHandle, iCallbackDestroyObject, ptr);
        }

        /// <summary>
        /// Signal that the action UpdateObject is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoUpdateObject must be overridden if this is called.</remarks>
        protected unsafe void EnableActionUpdateObject()
        {
            iCallbackUpdateObject = new CallbackUpdateObject(DoUpdateObject);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionUpdateObject(iHandle, iCallbackUpdateObject, ptr);
        }

        /// <summary>
        /// Signal that the action MoveObject is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoMoveObject must be overridden if this is called.</remarks>
        protected unsafe void EnableActionMoveObject()
        {
            iCallbackMoveObject = new CallbackMoveObject(DoMoveObject);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionMoveObject(iHandle, iCallbackMoveObject, ptr);
        }

        /// <summary>
        /// Signal that the action ImportResource is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoImportResource must be overridden if this is called.</remarks>
        protected unsafe void EnableActionImportResource()
        {
            iCallbackImportResource = new CallbackImportResource(DoImportResource);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionImportResource(iHandle, iCallbackImportResource, ptr);
        }

        /// <summary>
        /// Signal that the action ExportResource is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoExportResource must be overridden if this is called.</remarks>
        protected unsafe void EnableActionExportResource()
        {
            iCallbackExportResource = new CallbackExportResource(DoExportResource);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionExportResource(iHandle, iCallbackExportResource, ptr);
        }

        /// <summary>
        /// Signal that the action DeleteResource is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoDeleteResource must be overridden if this is called.</remarks>
        protected unsafe void EnableActionDeleteResource()
        {
            iCallbackDeleteResource = new CallbackDeleteResource(DoDeleteResource);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionDeleteResource(iHandle, iCallbackDeleteResource, ptr);
        }

        /// <summary>
        /// Signal that the action StopTransferResource is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoStopTransferResource must be overridden if this is called.</remarks>
        protected unsafe void EnableActionStopTransferResource()
        {
            iCallbackStopTransferResource = new CallbackStopTransferResource(DoStopTransferResource);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionStopTransferResource(iHandle, iCallbackStopTransferResource, ptr);
        }

        /// <summary>
        /// Signal that the action GetTransferProgress is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoGetTransferProgress must be overridden if this is called.</remarks>
        protected unsafe void EnableActionGetTransferProgress()
        {
            iCallbackGetTransferProgress = new CallbackGetTransferProgress(DoGetTransferProgress);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionGetTransferProgress(iHandle, iCallbackGetTransferProgress, ptr);
        }

        /// <summary>
        /// Signal that the action CreateReference is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// DoCreateReference must be overridden if this is called.</remarks>
        protected unsafe void EnableActionCreateReference()
        {
            iCallbackCreateReference = new CallbackCreateReference(DoCreateReference);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderUpnpOrgContentDirectory2EnableActionCreateReference(iHandle, iCallbackCreateReference, ptr);
        }

        /// <summary>
        /// GetSearchCapabilities action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// GetSearchCapabilities action for the owning device.
        ///
        /// Must be implemented iff EnableActionGetSearchCapabilities was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aSearchCaps"></param>
        protected virtual void GetSearchCapabilities(uint aVersion, out string aSearchCaps)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// GetSortCapabilities action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// GetSortCapabilities action for the owning device.
        ///
        /// Must be implemented iff EnableActionGetSortCapabilities was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aSortCaps"></param>
        protected virtual void GetSortCapabilities(uint aVersion, out string aSortCaps)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// GetSortExtensionCapabilities action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// GetSortExtensionCapabilities action for the owning device.
        ///
        /// Must be implemented iff EnableActionGetSortExtensionCapabilities was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aSortExtensionCaps"></param>
        protected virtual void GetSortExtensionCapabilities(uint aVersion, out string aSortExtensionCaps)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// GetFeatureList action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// GetFeatureList action for the owning device.
        ///
        /// Must be implemented iff EnableActionGetFeatureList was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aFeatureList"></param>
        protected virtual void GetFeatureList(uint aVersion, out string aFeatureList)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// GetSystemUpdateID action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// GetSystemUpdateID action for the owning device.
        ///
        /// Must be implemented iff EnableActionGetSystemUpdateID was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aId"></param>
        protected virtual void GetSystemUpdateID(uint aVersion, out uint aId)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// Browse action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Browse action for the owning device.
        ///
        /// Must be implemented iff EnableActionBrowse was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aObjectID"></param>
        /// <param name="aBrowseFlag"></param>
        /// <param name="aFilter"></param>
        /// <param name="aStartingIndex"></param>
        /// <param name="aRequestedCount"></param>
        /// <param name="aSortCriteria"></param>
        /// <param name="aResult"></param>
        /// <param name="aNumberReturned"></param>
        /// <param name="aTotalMatches"></param>
        /// <param name="aUpdateID"></param>
        protected virtual void Browse(uint aVersion, string aObjectID, string aBrowseFlag, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// Search action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Search action for the owning device.
        ///
        /// Must be implemented iff EnableActionSearch was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aContainerID"></param>
        /// <param name="aSearchCriteria"></param>
        /// <param name="aFilter"></param>
        /// <param name="aStartingIndex"></param>
        /// <param name="aRequestedCount"></param>
        /// <param name="aSortCriteria"></param>
        /// <param name="aResult"></param>
        /// <param name="aNumberReturned"></param>
        /// <param name="aTotalMatches"></param>
        /// <param name="aUpdateID"></param>
        protected virtual void Search(uint aVersion, string aContainerID, string aSearchCriteria, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// CreateObject action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// CreateObject action for the owning device.
        ///
        /// Must be implemented iff EnableActionCreateObject was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aContainerID"></param>
        /// <param name="aElements"></param>
        /// <param name="aObjectID"></param>
        /// <param name="aResult"></param>
        protected virtual void CreateObject(uint aVersion, string aContainerID, string aElements, out string aObjectID, out string aResult)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// DestroyObject action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// DestroyObject action for the owning device.
        ///
        /// Must be implemented iff EnableActionDestroyObject was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aObjectID"></param>
        protected virtual void DestroyObject(uint aVersion, string aObjectID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// UpdateObject action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// UpdateObject action for the owning device.
        ///
        /// Must be implemented iff EnableActionUpdateObject was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aObjectID"></param>
        /// <param name="aCurrentTagValue"></param>
        /// <param name="aNewTagValue"></param>
        protected virtual void UpdateObject(uint aVersion, string aObjectID, string aCurrentTagValue, string aNewTagValue)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// MoveObject action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// MoveObject action for the owning device.
        ///
        /// Must be implemented iff EnableActionMoveObject was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aObjectID"></param>
        /// <param name="aNewParentID"></param>
        /// <param name="aNewObjectID"></param>
        protected virtual void MoveObject(uint aVersion, string aObjectID, string aNewParentID, out string aNewObjectID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// ImportResource action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// ImportResource action for the owning device.
        ///
        /// Must be implemented iff EnableActionImportResource was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aSourceURI"></param>
        /// <param name="aDestinationURI"></param>
        /// <param name="aTransferID"></param>
        protected virtual void ImportResource(uint aVersion, string aSourceURI, string aDestinationURI, out uint aTransferID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// ExportResource action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// ExportResource action for the owning device.
        ///
        /// Must be implemented iff EnableActionExportResource was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aSourceURI"></param>
        /// <param name="aDestinationURI"></param>
        /// <param name="aTransferID"></param>
        protected virtual void ExportResource(uint aVersion, string aSourceURI, string aDestinationURI, out uint aTransferID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// DeleteResource action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// DeleteResource action for the owning device.
        ///
        /// Must be implemented iff EnableActionDeleteResource was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aResourceURI"></param>
        protected virtual void DeleteResource(uint aVersion, string aResourceURI)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// StopTransferResource action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// StopTransferResource action for the owning device.
        ///
        /// Must be implemented iff EnableActionStopTransferResource was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aTransferID"></param>
        protected virtual void StopTransferResource(uint aVersion, uint aTransferID)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// GetTransferProgress action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// GetTransferProgress action for the owning device.
        ///
        /// Must be implemented iff EnableActionGetTransferProgress was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aTransferID"></param>
        /// <param name="aTransferStatus"></param>
        /// <param name="aTransferLength"></param>
        /// <param name="aTransferTotal"></param>
        protected virtual void GetTransferProgress(uint aVersion, uint aTransferID, out string aTransferStatus, out string aTransferLength, out string aTransferTotal)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// CreateReference action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// CreateReference action for the owning device.
        ///
        /// Must be implemented iff EnableActionCreateReference was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aContainerID"></param>
        /// <param name="aObjectID"></param>
        /// <param name="aNewID"></param>
        protected virtual void CreateReference(uint aVersion, string aContainerID, string aObjectID, out string aNewID)
        {
            throw (new ActionDisabledError());
        }

        private static unsafe int DoGetSearchCapabilities(IntPtr aPtr, uint aVersion, char** aSearchCaps)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string searchCaps;
            self.GetSearchCapabilities(aVersion, out searchCaps);
            *aSearchCaps = (char*)Marshal.StringToHGlobalAnsi(searchCaps).ToPointer();
            return 0;
        }

        private static unsafe int DoGetSortCapabilities(IntPtr aPtr, uint aVersion, char** aSortCaps)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string sortCaps;
            self.GetSortCapabilities(aVersion, out sortCaps);
            *aSortCaps = (char*)Marshal.StringToHGlobalAnsi(sortCaps).ToPointer();
            return 0;
        }

        private static unsafe int DoGetSortExtensionCapabilities(IntPtr aPtr, uint aVersion, char** aSortExtensionCaps)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string sortExtensionCaps;
            self.GetSortExtensionCapabilities(aVersion, out sortExtensionCaps);
            *aSortExtensionCaps = (char*)Marshal.StringToHGlobalAnsi(sortExtensionCaps).ToPointer();
            return 0;
        }

        private static unsafe int DoGetFeatureList(IntPtr aPtr, uint aVersion, char** aFeatureList)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string featureList;
            self.GetFeatureList(aVersion, out featureList);
            *aFeatureList = (char*)Marshal.StringToHGlobalAnsi(featureList).ToPointer();
            return 0;
        }

        private static unsafe int DoGetSystemUpdateID(IntPtr aPtr, uint aVersion, uint* aId)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            uint id;
            self.GetSystemUpdateID(aVersion, out id);
            *aId = id;
            return 0;
        }

        private static unsafe int DoBrowse(IntPtr aPtr, uint aVersion, char* aObjectID, char* aBrowseFlag, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string objectID = Marshal.PtrToStringAnsi((IntPtr)aObjectID);
            string browseFlag = Marshal.PtrToStringAnsi((IntPtr)aBrowseFlag);
            string filter = Marshal.PtrToStringAnsi((IntPtr)aFilter);
            string sortCriteria = Marshal.PtrToStringAnsi((IntPtr)aSortCriteria);
            string result;
            uint numberReturned;
            uint totalMatches;
            uint updateID;
            self.Browse(aVersion, objectID, browseFlag, filter, aStartingIndex, aRequestedCount, sortCriteria, out result, out numberReturned, out totalMatches, out updateID);
            *aResult = (char*)Marshal.StringToHGlobalAnsi(result).ToPointer();
            *aNumberReturned = numberReturned;
            *aTotalMatches = totalMatches;
            *aUpdateID = updateID;
            return 0;
        }

        private static unsafe int DoSearch(IntPtr aPtr, uint aVersion, char* aContainerID, char* aSearchCriteria, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string containerID = Marshal.PtrToStringAnsi((IntPtr)aContainerID);
            string searchCriteria = Marshal.PtrToStringAnsi((IntPtr)aSearchCriteria);
            string filter = Marshal.PtrToStringAnsi((IntPtr)aFilter);
            string sortCriteria = Marshal.PtrToStringAnsi((IntPtr)aSortCriteria);
            string result;
            uint numberReturned;
            uint totalMatches;
            uint updateID;
            self.Search(aVersion, containerID, searchCriteria, filter, aStartingIndex, aRequestedCount, sortCriteria, out result, out numberReturned, out totalMatches, out updateID);
            *aResult = (char*)Marshal.StringToHGlobalAnsi(result).ToPointer();
            *aNumberReturned = numberReturned;
            *aTotalMatches = totalMatches;
            *aUpdateID = updateID;
            return 0;
        }

        private static unsafe int DoCreateObject(IntPtr aPtr, uint aVersion, char* aContainerID, char* aElements, char** aObjectID, char** aResult)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string containerID = Marshal.PtrToStringAnsi((IntPtr)aContainerID);
            string elements = Marshal.PtrToStringAnsi((IntPtr)aElements);
            string objectID;
            string result;
            self.CreateObject(aVersion, containerID, elements, out objectID, out result);
            *aObjectID = (char*)Marshal.StringToHGlobalAnsi(objectID).ToPointer();
            *aResult = (char*)Marshal.StringToHGlobalAnsi(result).ToPointer();
            return 0;
        }

        private static unsafe int DoDestroyObject(IntPtr aPtr, uint aVersion, char* aObjectID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string objectID = Marshal.PtrToStringAnsi((IntPtr)aObjectID);
            self.DestroyObject(aVersion, objectID);
            return 0;
        }

        private static unsafe int DoUpdateObject(IntPtr aPtr, uint aVersion, char* aObjectID, char* aCurrentTagValue, char* aNewTagValue)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string objectID = Marshal.PtrToStringAnsi((IntPtr)aObjectID);
            string currentTagValue = Marshal.PtrToStringAnsi((IntPtr)aCurrentTagValue);
            string newTagValue = Marshal.PtrToStringAnsi((IntPtr)aNewTagValue);
            self.UpdateObject(aVersion, objectID, currentTagValue, newTagValue);
            return 0;
        }

        private static unsafe int DoMoveObject(IntPtr aPtr, uint aVersion, char* aObjectID, char* aNewParentID, char** aNewObjectID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string objectID = Marshal.PtrToStringAnsi((IntPtr)aObjectID);
            string newParentID = Marshal.PtrToStringAnsi((IntPtr)aNewParentID);
            string newObjectID;
            self.MoveObject(aVersion, objectID, newParentID, out newObjectID);
            *aNewObjectID = (char*)Marshal.StringToHGlobalAnsi(newObjectID).ToPointer();
            return 0;
        }

        private static unsafe int DoImportResource(IntPtr aPtr, uint aVersion, char* aSourceURI, char* aDestinationURI, uint* aTransferID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string sourceURI = Marshal.PtrToStringAnsi((IntPtr)aSourceURI);
            string destinationURI = Marshal.PtrToStringAnsi((IntPtr)aDestinationURI);
            uint transferID;
            self.ImportResource(aVersion, sourceURI, destinationURI, out transferID);
            *aTransferID = transferID;
            return 0;
        }

        private static unsafe int DoExportResource(IntPtr aPtr, uint aVersion, char* aSourceURI, char* aDestinationURI, uint* aTransferID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string sourceURI = Marshal.PtrToStringAnsi((IntPtr)aSourceURI);
            string destinationURI = Marshal.PtrToStringAnsi((IntPtr)aDestinationURI);
            uint transferID;
            self.ExportResource(aVersion, sourceURI, destinationURI, out transferID);
            *aTransferID = transferID;
            return 0;
        }

        private static unsafe int DoDeleteResource(IntPtr aPtr, uint aVersion, char* aResourceURI)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string resourceURI = Marshal.PtrToStringAnsi((IntPtr)aResourceURI);
            self.DeleteResource(aVersion, resourceURI);
            return 0;
        }

        private static unsafe int DoStopTransferResource(IntPtr aPtr, uint aVersion, uint aTransferID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            self.StopTransferResource(aVersion, aTransferID);
            return 0;
        }

        private static unsafe int DoGetTransferProgress(IntPtr aPtr, uint aVersion, uint aTransferID, char** aTransferStatus, char** aTransferLength, char** aTransferTotal)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string transferStatus;
            string transferLength;
            string transferTotal;
            self.GetTransferProgress(aVersion, aTransferID, out transferStatus, out transferLength, out transferTotal);
            *aTransferStatus = (char*)Marshal.StringToHGlobalAnsi(transferStatus).ToPointer();
            *aTransferLength = (char*)Marshal.StringToHGlobalAnsi(transferLength).ToPointer();
            *aTransferTotal = (char*)Marshal.StringToHGlobalAnsi(transferTotal).ToPointer();
            return 0;
        }

        private static unsafe int DoCreateReference(IntPtr aPtr, uint aVersion, char* aContainerID, char* aObjectID, char** aNewID)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderUpnpOrgContentDirectory2 self = (DvProviderUpnpOrgContentDirectory2)gch.Target;
            string containerID = Marshal.PtrToStringAnsi((IntPtr)aContainerID);
            string objectID = Marshal.PtrToStringAnsi((IntPtr)aObjectID);
            string newID;
            self.CreateReference(aVersion, containerID, objectID, out newID);
            *aNewID = (char*)Marshal.StringToHGlobalAnsi(newID).ToPointer();
            return 0;
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public void Dispose()
        {
            DoDispose();
            GC.SuppressFinalize(this);
        }

        ~DvProviderUpnpOrgContentDirectory2()
        {
            DoDispose();
        }

        private void DoDispose()
        {
            IntPtr handle;
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                handle = iHandle;
                iHandle = IntPtr.Zero;
            }
            DvProviderUpnpOrgContentDirectory2Destroy(handle);
            if (iGch.IsAllocated)
            {
                iGch.Free();
            }
        }
    }
}

