using System;

namespace DevIO.UI.Site.Servicos
{

    public class OperacaoService
    {
     

        public OperacaoService(IOperacaoTransient operacaoTransient, 
                               IOperacaoScoped operacaoScoped, 
                               IOperacaoSingleton operacaoSingleton, 
                               IOperacaoSingletonInstance operacaoSingletonInstance)
        {
            OperacaoTransient = operacaoTransient;
            OperacaoScoped = operacaoScoped;
            OperacaoSingleton = operacaoSingleton;
            OperacaoSingletonInstance = operacaoSingletonInstance;
        }

        public IOperacaoTransient OperacaoTransient { get; }
        public IOperacaoScoped OperacaoScoped { get; }
        public IOperacaoSingleton OperacaoSingleton { get; }
        public IOperacaoSingletonInstance OperacaoSingletonInstance { get; }
    }


    public class Operacao : IOperacaoTransient,
                            IOperacaoScoped,
                            IOperacaoSingleton,
                              IOperacaoSingletonInstance
    {
        public Guid OperacaoId { get; private set; }

        public Operacao() : this(Guid.NewGuid())
        {

        }

        public Operacao(Guid guid)
        {
            OperacaoId = guid;
        }
    
    }

    public interface IOperacao
    {
        Guid OperacaoId { get; }
    }

    public interface IOperacaoTransient : IOperacao
    {
    }

    public interface IOperacaoScoped : IOperacao
    {
    }

    public interface IOperacaoSingleton : IOperacao
    {
    }

    public interface IOperacaoSingletonInstance : IOperacao
    {
    }

}
