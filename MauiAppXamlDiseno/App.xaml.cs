﻿using MauiAppXamlDiseno.TiposPaginas;

namespace MauiAppXamlDiseno;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new UnaContentPage();
    }
}

