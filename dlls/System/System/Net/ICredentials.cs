using System.Collections;

namespace System.ComponentModel;

/// <summary>Extends the <see cref="T:System.ComponentModel.IBindingList" /> interface by providing advanced sorting and filtering capabilities.</summary>
public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable
{
	string Filter { get; set; }

	ListSortDescriptionCollection SortDescriptions { get; }

	bool SupportsAdvancedSorting { get; }

	bool SupportsFiltering { get; }

	void ApplySort(ListSortDescriptionCollection sorts);

	void RemoveFilter();
}
