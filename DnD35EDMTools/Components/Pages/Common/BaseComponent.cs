using DnD35EDMTools.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace DnD35EDMTools.Components.Pages.Common;

public class BaseComponent : ComponentBase
{
    [Inject] protected IDbContextFactory<ApplicationDbContext> DbContextFactory { get; set; }
    protected ApplicationDbContext CreateDbContext() => DbContextFactory.CreateDbContext();
}