namespace Aula_02.Utils
{
    public class IsAnyNull
    {
        public static string Check(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                {
                    return property.Name;
                }
            }
            return null;
        }
    }
}