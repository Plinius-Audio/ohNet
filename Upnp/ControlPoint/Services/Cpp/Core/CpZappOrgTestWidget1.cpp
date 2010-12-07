#include <Core/CpZappOrgTestWidget1.h>
#include <CpProxy.h>
#include <CpiService.h>
#include <Thread.h>
#include <AsyncPrivate.h>
#include <Core/CpDevice.h>

using namespace Zapp;


class SyncSetReadWriteRegisterZappOrgTestWidget1 : public SyncProxyAction
{
public:
    SyncSetReadWriteRegisterZappOrgTestWidget1(CpProxyZappOrgTestWidget1& aProxy);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyZappOrgTestWidget1& iService;
};

SyncSetReadWriteRegisterZappOrgTestWidget1::SyncSetReadWriteRegisterZappOrgTestWidget1(CpProxyZappOrgTestWidget1& aProxy)
    : iService(aProxy)
{
}

void SyncSetReadWriteRegisterZappOrgTestWidget1::CompleteRequest(IAsync& aAsync)
{
    iService.EndSetReadWriteRegister(aAsync);
}


class SyncGetWidgetClassZappOrgTestWidget1 : public SyncProxyAction
{
public:
    SyncGetWidgetClassZappOrgTestWidget1(CpProxyZappOrgTestWidget1& aProxy, TUint& aWidgetClass);
    virtual void CompleteRequest(IAsync& aAsync);
private:
    CpProxyZappOrgTestWidget1& iService;
    TUint& iWidgetClass;
};

SyncGetWidgetClassZappOrgTestWidget1::SyncGetWidgetClassZappOrgTestWidget1(CpProxyZappOrgTestWidget1& aProxy, TUint& aWidgetClass)
    : iService(aProxy)
    , iWidgetClass(aWidgetClass)
{
}

void SyncGetWidgetClassZappOrgTestWidget1::CompleteRequest(IAsync& aAsync)
{
    iService.EndGetWidgetClass(aAsync, iWidgetClass);
}


CpProxyZappOrgTestWidget1::CpProxyZappOrgTestWidget1(CpDevice& aDevice)
    : CpProxy("zapp-org", "TestWidget", 1, aDevice.Device())
{
    Zapp::Parameter* param;

    iActionSetReadWriteRegister = new Action("SetReadWriteRegister");
    param = new Zapp::ParameterUint("RegisterIndex");
    iActionSetReadWriteRegister->AddInputParameter(param);
    param = new Zapp::ParameterUint("RegisterValue");
    iActionSetReadWriteRegister->AddInputParameter(param);

    iActionGetWidgetClass = new Action("GetWidgetClass");
    param = new Zapp::ParameterUint("WidgetClass");
    iActionGetWidgetClass->AddOutputParameter(param);

    Functor functor;
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadWriteRegister0PropertyChanged);
    iReadWriteRegister0 = new PropertyUint("ReadWriteRegister0", functor);
    AddProperty(iReadWriteRegister0);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadWriteRegister1PropertyChanged);
    iReadWriteRegister1 = new PropertyUint("ReadWriteRegister1", functor);
    AddProperty(iReadWriteRegister1);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadWriteRegister2PropertyChanged);
    iReadWriteRegister2 = new PropertyUint("ReadWriteRegister2", functor);
    AddProperty(iReadWriteRegister2);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadWriteRegister3PropertyChanged);
    iReadWriteRegister3 = new PropertyUint("ReadWriteRegister3", functor);
    AddProperty(iReadWriteRegister3);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadOnlyRegister4PropertyChanged);
    iReadOnlyRegister4 = new PropertyUint("ReadOnlyRegister4", functor);
    AddProperty(iReadOnlyRegister4);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadOnlyRegister5PropertyChanged);
    iReadOnlyRegister5 = new PropertyUint("ReadOnlyRegister5", functor);
    AddProperty(iReadOnlyRegister5);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadOnlyRegister6PropertyChanged);
    iReadOnlyRegister6 = new PropertyUint("ReadOnlyRegister6", functor);
    AddProperty(iReadOnlyRegister6);
    functor = MakeFunctor(*this, &CpProxyZappOrgTestWidget1::ReadOnlyRegister7PropertyChanged);
    iReadOnlyRegister7 = new PropertyUint("ReadOnlyRegister7", functor);
    AddProperty(iReadOnlyRegister7);
}

CpProxyZappOrgTestWidget1::~CpProxyZappOrgTestWidget1()
{
    DestroyService();
    delete iActionSetReadWriteRegister;
    delete iActionGetWidgetClass;
}

void CpProxyZappOrgTestWidget1::SyncSetReadWriteRegister(TUint aRegisterIndex, TUint aRegisterValue)
{
    SyncSetReadWriteRegisterZappOrgTestWidget1 sync(*this);
    BeginSetReadWriteRegister(aRegisterIndex, aRegisterValue, sync.Functor());
    sync.Wait();
}

void CpProxyZappOrgTestWidget1::BeginSetReadWriteRegister(TUint aRegisterIndex, TUint aRegisterValue, FunctorAsync& aFunctor)
{
    Invocation* invocation = iService->Invocation(*iActionSetReadWriteRegister, aFunctor);
    TUint inIndex = 0;
    const Action::VectorParameters& inParams = iActionSetReadWriteRegister->InputParameters();
    invocation->AddInput(new ArgumentUint(*inParams[inIndex++], aRegisterIndex));
    invocation->AddInput(new ArgumentUint(*inParams[inIndex++], aRegisterValue));
    iInvocable.InvokeAction(*invocation);
}

void CpProxyZappOrgTestWidget1::EndSetReadWriteRegister(IAsync& aAsync)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("SetReadWriteRegister"));

    if (invocation.Error()) {
        THROW(ProxyError);
    }
}

void CpProxyZappOrgTestWidget1::SyncGetWidgetClass(TUint& aWidgetClass)
{
    SyncGetWidgetClassZappOrgTestWidget1 sync(*this, aWidgetClass);
    BeginGetWidgetClass(sync.Functor());
    sync.Wait();
}

void CpProxyZappOrgTestWidget1::BeginGetWidgetClass(FunctorAsync& aFunctor)
{
    Invocation* invocation = iService->Invocation(*iActionGetWidgetClass, aFunctor);
    TUint outIndex = 0;
    const Action::VectorParameters& outParams = iActionGetWidgetClass->OutputParameters();
    invocation->AddOutput(new ArgumentUint(*outParams[outIndex++]));
    iInvocable.InvokeAction(*invocation);
}

void CpProxyZappOrgTestWidget1::EndGetWidgetClass(IAsync& aAsync, TUint& aWidgetClass)
{
    ASSERT(((Async&)aAsync).Type() == Async::eInvocation);
    Invocation& invocation = (Invocation&)aAsync;
    ASSERT(invocation.Action().Name() == Brn("GetWidgetClass"));

    if (invocation.Error()) {
        THROW(ProxyError);
    }
    TUint index = 0;
    aWidgetClass = ((ArgumentUint*)invocation.OutputArguments()[index++])->Value();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadWriteRegister0Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadWriteRegister0Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadWriteRegister1Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadWriteRegister1Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadWriteRegister2Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadWriteRegister2Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadWriteRegister3Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadWriteRegister3Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadOnlyRegister4Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadOnlyRegister4Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadOnlyRegister5Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadOnlyRegister5Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadOnlyRegister6Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadOnlyRegister6Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::SetPropertyReadOnlyRegister7Changed(Functor& aFunctor)
{
    iLock->Wait();
    iReadOnlyRegister7Changed = aFunctor;
    iLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadWriteRegister0(TUint& aReadWriteRegister0) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadWriteRegister0 = iReadWriteRegister0->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadWriteRegister1(TUint& aReadWriteRegister1) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadWriteRegister1 = iReadWriteRegister1->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadWriteRegister2(TUint& aReadWriteRegister2) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadWriteRegister2 = iReadWriteRegister2->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadWriteRegister3(TUint& aReadWriteRegister3) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadWriteRegister3 = iReadWriteRegister3->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadOnlyRegister4(TUint& aReadOnlyRegister4) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadOnlyRegister4 = iReadOnlyRegister4->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadOnlyRegister5(TUint& aReadOnlyRegister5) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadOnlyRegister5 = iReadOnlyRegister5->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadOnlyRegister6(TUint& aReadOnlyRegister6) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadOnlyRegister6 = iReadOnlyRegister6->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::PropertyReadOnlyRegister7(TUint& aReadOnlyRegister7) const
{
    iPropertyLock->Wait();
    ASSERT(iCpSubscriptionStatus == CpProxy::eSubscribed);
    aReadOnlyRegister7 = iReadOnlyRegister7->Value();
    iPropertyLock->Signal();
}

void CpProxyZappOrgTestWidget1::ReadWriteRegister0PropertyChanged()
{
    ReportEvent(iReadWriteRegister0Changed);
}

void CpProxyZappOrgTestWidget1::ReadWriteRegister1PropertyChanged()
{
    ReportEvent(iReadWriteRegister1Changed);
}

void CpProxyZappOrgTestWidget1::ReadWriteRegister2PropertyChanged()
{
    ReportEvent(iReadWriteRegister2Changed);
}

void CpProxyZappOrgTestWidget1::ReadWriteRegister3PropertyChanged()
{
    ReportEvent(iReadWriteRegister3Changed);
}

void CpProxyZappOrgTestWidget1::ReadOnlyRegister4PropertyChanged()
{
    ReportEvent(iReadOnlyRegister4Changed);
}

void CpProxyZappOrgTestWidget1::ReadOnlyRegister5PropertyChanged()
{
    ReportEvent(iReadOnlyRegister5Changed);
}

void CpProxyZappOrgTestWidget1::ReadOnlyRegister6PropertyChanged()
{
    ReportEvent(iReadOnlyRegister6Changed);
}

void CpProxyZappOrgTestWidget1::ReadOnlyRegister7PropertyChanged()
{
    ReportEvent(iReadOnlyRegister7Changed);
}

