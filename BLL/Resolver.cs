using System;
using System.ComponentModel.Composition;
using System.Xml;
using BLL;
using DependencyResolver;

[Export(typeof(IComponent))]
public class Resolver : IComponent
{
    public void SetUp(IRegisterComponent registerComponent)
    {
        registerComponent.RegisterType<INode, Node>();
    }
}
