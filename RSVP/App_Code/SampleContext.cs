using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Сводное описание для SampleContext
/// </summary>
public class SampleContext 
{
    public DbSet<GuestResponse> GuestResponses { get; set; }
    public DbSet<Report> reports { get; set; }
}