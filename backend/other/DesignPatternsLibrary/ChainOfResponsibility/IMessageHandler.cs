﻿namespace DesignPatternsLibrary.ChainOfResponsibility
{
    public interface IMessageHandler
    {
        Task<OperationResult> HandleMessageAsync(IMessage message);
    }
}
