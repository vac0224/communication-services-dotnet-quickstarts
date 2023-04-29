﻿// Copyright (c) 2023 Jason Shave. All rights reserved.
// Licensed under the MIT License.

using Azure.Communication.CallAutomation;
using CallAutomation.Playground.Interfaces;

namespace CallAutomation.Playground.Tones;

public struct Eight : IDtmfTone
{
    public DtmfTone Value => DtmfTone.Eight;
}