﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal._3._Models.Persistence;
public interface IRepository
{
    public void Create();
    public void Read();
    public void ReadAll();
    public void Update();
    public void Delete();
}
