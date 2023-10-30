﻿using System.Net;

namespace MoscowApi.Logic.Models;

public class FailedLogicResult : GenericLogicResult
{
    public override bool Status => false;
    public override HttpStatusCode HttpCode { get; init; } = HttpStatusCode.BadRequest;
}