﻿using System;
using System.Collections.Generic;

namespace SnowBack.Models;

public partial class DKbDoc
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public int Relatedobject { get; set; }

    public bool Type { get; set; }

    public string Name { get; set; } = null!;

    public string Filepath { get; set; } = null!;

    public byte[]? Description { get; set; }
}
