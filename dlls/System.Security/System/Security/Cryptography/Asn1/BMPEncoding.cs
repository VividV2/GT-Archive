namespace System.Security.Cryptography.Pkcs;

public abstract class RecipientInfo
{
	[CompilerGenerated]
	private readonly RecipientInfoType <Type>k__BackingField;

	[CompilerGenerated]
	private readonly RecipientInfoPal <Pal>k__BackingField;

	public RecipientInfoType Type
	{
		[CompilerGenerated]
		get
		{
			return <Type>k__BackingField;
		}
	}

	public abstract int Version { get; }

	public abstract SubjectIdentifier RecipientIdentifier { get; }

	public abstract AlgorithmIdentifier KeyEncryptionAlgorithm { get; }

	public abstract byte[] EncryptedKey { get; }

	internal RecipientInfoPal Pal
	{
		[CompilerGenerated]
		get
		{
			return <Pal>k__BackingField;
		}
	}

	internal RecipientInfo(RecipientInfoType type, RecipientInfoPal pal)
	{
		base..ctor();
		<Type>k__BackingField = type;
		<Pal>k__BackingField = pal;
	}

	internal RecipientInfo()
	{
		ThrowStub.ThrowNotSupportedException();
	}
}
