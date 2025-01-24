using System.Text.Json;

namespace OTOSOLVE.UI.Utilities;
public class Utility
{
    public static Dictionary<string, List<string>> ExtractErrorsFromWebAPIResponse(string body)
    {
        Dictionary<string, List<string>>? response = [];

        JsonElement jsonElement = JsonSerializer.Deserialize<JsonElement>(body);
        JsonElement errorsJsonElement = jsonElement.GetProperty("errors");
        foreach (JsonProperty fieldWithErrors in errorsJsonElement.EnumerateObject())
        {
            string? field = fieldWithErrors.Name;
            List<string>? errors = [];
            foreach (JsonElement errorKind in fieldWithErrors.Value.EnumerateArray())
            {
                string? error = errorKind.GetString();
                errors.Add(error);
            }

            response.Add(field, errors);
        }

        return response;
    }
}