using System.Collections;
using Unity;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Supports a simple iteration over an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />. This class cannot be inherited.</summary>
	public sealed class X509ChainElementEnumerator : IEnumerator
	{
		private IEnumerator enumerator;

		/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element.</exception>
		public X509ChainElement Current => (X509ChainElement)enumerator.Current;

		/// <summary>Gets the current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>The current element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element.</exception>
		object IEnumerator.Current => enumerator.Current;

		internal X509ChainElementEnumerator(IEnumerable enumerable)
		{
			enumerator = enumerable.GetEnumerator();
		}

		/// <summary>Advances the enumerator to the next element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <returns>
		///   <see langword="true" /> if the enumerator was successfully advanced to the next element; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
		public bool MoveNext()
		{
			return enumerator.MoveNext();
		}

		/// <summary>Sets the enumerator to its initial position, which is before the first element in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
		public void Reset()
		{
			enumerator.Reset();
		}

		internal X509ChainElementEnumerator()
		{
			Unity.ThrowStub.ThrowNotSupportedException();
		}
	}
}
namespace System.Configuration
{
	internal class ConfigHelper
	{
		private class CollectionWrapper
		{
			private IDictionary dict;

			private NameValueCollection collection;

			private bool isDict;

			public string this[string key]
			{
				set
				{
					if (isDict)
					{
						dict[key] = value;
					}
					else
					{
						collection[key] = value;
					}
				}
			}

			public CollectionWrapper(IDictionary dict)
			{
				base..ctor();
				this.dict = dict;
				isDict = true;
			}

			public CollectionWrapper(NameValueCollection collection)
			{
				base..ctor();
				this.collection = collection;
				isDict = false;
			}

			public void Remove(string s)
			{
				if (isDict)
				{
					dict.Remove(s);
				}
				else
				{
					collection.Remove(s);
				}
			}

			public void Clear()
			{
				if (isDict)
				{
					dict.Clear();
				}
				else
				{
					collection.Clear();
				}
			}

			public object UnWrap()
			{
				if (isDict)
					return dict;
				return collection;
			}
		}

		internal static IDictionary GetDictionary(IDictionary prev, XmlNode region, string nameAtt, string valueAtt)
		{
			dict = prev != null ? (Hashtable)(Hashtable)prev.Clone() : new Hashtable(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
			result = new CollectionWrapper(dict);
			result = GoGetThem(result, region, nameAtt, valueAtt);
			if (result == null)
				return null;
			return result.UnWrap() as IDictionary;
		}

		internal static ConfigNameValueCollection GetNameValueCollection(NameValueCollection prev, XmlNode region, string nameAtt, string valueAtt)
		{
			configNameValueCollection = new ConfigNameValueCollection(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
			if (prev != null)
			{
				configNameValueCollection.Add(prev);
			}
			result = new CollectionWrapper(configNameValueCollection);
			result = GoGetThem(result, region, nameAtt, valueAtt);
			if (result == null)
				return null;
			return result.UnWrap() as ConfigNameValueCollection;
		}

		private static CollectionWrapper GoGetThem(CollectionWrapper result, XmlNode region, string nameAtt, string valueAtt)
		{
			if (region.Attributes != null && region.Attributes.Count != 0 && region.Attributes.Count != 1 || string.op_Inequality(region.Attributes[0].Name, "xmlns"))
				throw new ConfigurationException("Unknown attribute", region);
			foreach (XmlNode childNode in region.ChildNodes)
			{
				switch (childNode.NodeType)
				{
				default:
				{
					throw new ConfigurationException("Only XmlElement allowed", childNode);
				}
				case XmlNodeType.Element:
				{
					switch (childNode.Name)
					{
					case "clear":
					{
						if (childNode.Attributes != null && childNode.Attributes.Count != 0)
							throw new ConfigurationException("Unknown attribute", childNode);
						result.Clear();
						break;
					}
					case "remove":
					{
						xmlNode2 = null;
						if (childNode.Attributes != null)
						{
							xmlNode2 = childNode.Attributes.RemoveNamedItem(nameAtt);
						}
						if (xmlNode2 == null)
							throw new ConfigurationException("Required attribute not found", childNode);
						if (string.op_Equality(xmlNode2.Value, string.Empty))
							throw new ConfigurationException("Required attribute is empty", childNode);
						if (childNode.Attributes.Count != 0)
							throw new ConfigurationException("Unknown attribute", childNode);
						result.Remove(xmlNode2.Value);
						break;
					}
					case "add":
					{
						xmlNode2 = null;
						if (childNode.Attributes != null)
						{
							xmlNode2 = childNode.Attributes.RemoveNamedItem(nameAtt);
						}
						if (xmlNode2 == null)
							throw new ConfigurationException("Required attribute not found", childNode);
						if (string.op_Equality(xmlNode2.Value, string.Empty))
							throw new ConfigurationException("Required attribute is empty", childNode);
						xmlNode3 = childNode.Attributes.RemoveNamedItem(valueAtt);
						if (xmlNode3 == null)
							throw new ConfigurationException("Required attribute not found", childNode);
						if (childNode.Attributes.Count != 0)
							throw new ConfigurationException("Unknown attribute", childNode);
						result[xmlNode2.Value] = xmlNode3.Value;
						break;
					}
					default:
					{
						throw new ConfigurationException("Unknown element", childNode);
					}
					}
					break;
				}
				case XmlNodeType.Comment:
				case XmlNodeType.Whitespace:
					break;
				}
			}
			return result;
		}

		public ConfigHelper()
		{
			base..ctor();
		}
	}
}
