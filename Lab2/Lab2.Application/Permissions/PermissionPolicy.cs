namespace Lab2.Application.Permissions;

public static class PermissionPolicy
{
    private const string PermissionPrefix = "Permission.";
    
    public static class RolePermission
    {
        private const string DefaultPrefix = PermissionPrefix + "Role";
        
        public const string View = $"{DefaultPrefix}.View";
        public const string Edit = $"{DefaultPrefix}.Edit";
    }

    public static class UserPermission
    {
        private const string DefaultPrefix = PermissionPrefix + "User";

        public const string View = $"{DefaultPrefix}.View";
        public const string Create = $"{DefaultPrefix}.Create";
        public const string Edit = $"{DefaultPrefix}.Edit";
        public const string Delete = $"{DefaultPrefix}.Delete";
    }

    public static class ProductPermission
    {
        private const string DefaultPrefix = PermissionPrefix + "Product";

        public const string View = $"{DefaultPrefix}.View";
        public const string Create = $"{DefaultPrefix}.Create";
        public const string Edit = $"{DefaultPrefix}.Edit";
        public const string Delete = $"{DefaultPrefix}.Delete";
    }

    public static class AccountPermission
    {
        private const string DefaultPrefix = PermissionPrefix + "Account";

        public const string View = $"{DefaultPrefix}.View";
        public const string Create = $"{DefaultPrefix}.Create";
        public const string Edit = $"{DefaultPrefix}.Edit";
        public const string Delete = $"{DefaultPrefix}.Delete";
    }

    public static class LeadPermission
    {
        private const string DefaultPrefix = PermissionPrefix + "Lead";

        public const string View = $"{DefaultPrefix}.View";
        public const string Create = $"{DefaultPrefix}.Create";
        public const string Edit = $"{DefaultPrefix}.Edit";
        public const string Qualify = $"{DefaultPrefix}.Qualify";
        public const string Disqualify = $"{DefaultPrefix}.Disqualify";
        public const string Delete = $"{DefaultPrefix}.Delete";
    }

    public static class DealPermission
    {
        private const string DefaultPrefix = PermissionPrefix + "Deal";

        public const string View = $"{DefaultPrefix}.View";
        public const string Edit = $"{DefaultPrefix}.Edit";
        public const string EndDeal = $"{DefaultPrefix}.EndDeal";
        public const string Delete = $"{DefaultPrefix}.Delete";
        
        public const string ViewProduct = $"{DefaultPrefix}.Product.View";
        public const string AddProduct = $"{DefaultPrefix}.Product.Add";
        public const string EditProduct = $"{DefaultPrefix}.Product.Edit";
        public const string DeleteProduct = $"{DefaultPrefix}.Product.Delete";
    }
    
    public static class ContactPermission
    {
        private const string DefaultPrefix = PermissionPrefix + "Contact";

        public const string View = $"{DefaultPrefix}.View";
        public const string Create = $"{DefaultPrefix}.Create";
        public const string Edit = $"{DefaultPrefix}.Edit";
        public const string Delete = $"{DefaultPrefix}.Delete";
    }
}


