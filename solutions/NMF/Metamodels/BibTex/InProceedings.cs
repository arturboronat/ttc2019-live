//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2019.LiveContest.Metamodels.Bibtex
{
    
    
    /// <summary>
    /// The default implementation of the InProceedings class
    /// </summary>
    [XmlNamespaceAttribute("https://www.transformation-tool-contest.eu/2019/bibtex")]
    [XmlNamespacePrefixAttribute("bib")]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/bibtex#//InProceedings")]
    public partial class InProceedings : Proceedings, IInProceedings, IModelElement
    {
        
        private static Lazy<ITypedElement> _authorsReference = new Lazy<ITypedElement>(RetrieveAuthorsReference);
        
        /// <summary>
        /// The backing field for the Authors property
        /// </summary>
        private ObservableCompositionOrderedSet<IAuthor> _authors;
        
        /// <summary>
        /// The backing field for the Booktitle property
        /// </summary>
        private string _booktitle;
        
        private static Lazy<ITypedElement> _booktitleAttribute = new Lazy<ITypedElement>(RetrieveBooktitleAttribute);
        
        private static IClass _classInstance;
        
        public InProceedings()
        {
            this._authors = new ObservableCompositionOrderedSet<IAuthor>(this);
            this._authors.CollectionChanging += this.AuthorsCollectionChanging;
            this._authors.CollectionChanged += this.AuthorsCollectionChanged;
        }
        
        /// <summary>
        /// The authors property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("authors")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<IAuthor> Authors
        {
            get
            {
                return this._authors;
            }
        }
        
        /// <summary>
        /// The booktitle property
        /// </summary>
        [DisplayNameAttribute("booktitle")]
        [CategoryAttribute("BookTitledEntry")]
        [XmlElementNameAttribute("booktitle")]
        [XmlAttributeAttribute(true)]
        public string Booktitle
        {
            get
            {
                return this._booktitle;
            }
            set
            {
                if ((this._booktitle != value))
                {
                    string old = this._booktitle;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBooktitleChanging(e);
                    this.OnPropertyChanging("Booktitle", e, _booktitleAttribute);
                    this._booktitle = value;
                    this.OnBooktitleChanged(e);
                    this.OnPropertyChanged("Booktitle", e, _booktitleAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new InProceedingsChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/bibtex#//InProceedings")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Booktitle property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BooktitleChanging;
        
        /// <summary>
        /// Gets fired when the Booktitle property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BooktitleChanged;
        
        private static ITypedElement RetrieveAuthorsReference()
        {
            return ((ITypedElement)(((ModelElement)(AuthoredEntry.ClassInstance)).Resolve("authors")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Authors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AuthorsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Authors", e, _authorsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Authors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AuthorsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Authors", e, _authorsReference);
        }
        
        private static ITypedElement RetrieveBooktitleAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BookTitledEntry.ClassInstance)).Resolve("booktitle")));
        }
        
        /// <summary>
        /// Raises the BooktitleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBooktitleChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BooktitleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BooktitleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBooktitleChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BooktitleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int authorsIndex = ModelHelper.IndexOfReference(this.Authors, element);
            if ((authorsIndex != -1))
            {
                return ModelHelper.CreatePath("authors", authorsIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "AUTHORS"))
            {
                if ((index < this.Authors.Count))
                {
                    return this.Authors[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "BOOKTITLE"))
            {
                return this.Booktitle;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "AUTHORS"))
            {
                return this._authors;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "BOOKTITLE"))
            {
                this.Booktitle = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "BOOKTITLE"))
            {
                return new BooktitleProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._authors))
            {
                return "authors";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/bibtex#//InProceedings")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the InProceedings class
        /// </summary>
        public class InProceedingsChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private InProceedings _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InProceedingsChildrenCollection(InProceedings parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Authors.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Authors.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Authors.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAuthor authorsCasted = item.As<IAuthor>();
                if ((authorsCasted != null))
                {
                    this._parent.Authors.Add(authorsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Authors.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Authors.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> authorsEnumerator = this._parent.Authors.GetEnumerator();
                try
                {
                    for (
                    ; authorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = authorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    authorsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAuthor authorItem = item.As<IAuthor>();
                if (((authorItem != null) 
                            && this._parent.Authors.Remove(authorItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Authors).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the booktitle property
        /// </summary>
        private sealed class BooktitleProxy : ModelPropertyChange<IBookTitledEntry, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BooktitleProxy(IBookTitledEntry modelElement) : 
                    base(modelElement, "booktitle")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Booktitle;
                }
                set
                {
                    this.ModelElement.Booktitle = value;
                }
            }
        }
    }
}
