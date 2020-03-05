﻿using System;

namespace AbstractFactory
{
    public abstract class CarroFactory 
    {
        public abstract Roda montarRoda();
        public abstract Som montarSom();
    }
}
