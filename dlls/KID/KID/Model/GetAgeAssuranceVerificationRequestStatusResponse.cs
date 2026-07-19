using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace KID.Model;

[DataContract(Name = "IssueAuthTokenResponse")]
public class IssueAuthTokenResponse(string accessToken = null, string refreshToken = null)
{
	[DataMember(Name = "accessToken", EmitDefaultValue = false)]
	public string AccessToken { get; set; } = accessToken;

	[DataMember(Name = "refreshToken", EmitDefaultValue = false)]
	public string RefreshToken { get; set; } = refreshToken;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder;
		stringBuilder.Append("class IssueAuthTokenResponse {\n");
		stringBuilder.Append("  AccessToken: ").Append(AccessToken).Append("\n");
		stringBuilder.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
		stringBuilder.Append("}\n");
		return stringBuilder.ToString();
	}

	public virtual string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}
}
