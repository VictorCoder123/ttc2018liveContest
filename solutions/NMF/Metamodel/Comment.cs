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

namespace TTC2018.LiveContest.SocialNetwork
{
    
    
    /// <summary>
    /// The default implementation of the Comment class
    /// </summary>
    [XmlNamespaceAttribute("https://www.transformation-tool-contest.eu/2018/social_media")]
    [XmlNamespacePrefixAttribute("social")]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2018/social_media#//Comment")]
    [DebuggerDisplayAttribute("Comment {Id}")]
    public partial class Comment : Submission, IComment, IModelElement
    {
        
        private static Lazy<ITypedElement> _commentedReference = new Lazy<ITypedElement>(RetrieveCommentedReference);
        
        private static Lazy<ITypedElement> _likedByReference = new Lazy<ITypedElement>(RetrieveLikedByReference);
        
        /// <summary>
        /// The backing field for the LikedBy property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private CommentLikedByCollection _likedBy;
        
        private static IClass _classInstance;
        
        public Comment()
        {
            this._likedBy = new CommentLikedByCollection(this);
            this._likedBy.CollectionChanging += this.LikedByCollectionChanging;
            this._likedBy.CollectionChanged += this.LikedByCollectionChanged;
        }
        
        /// <summary>
        /// The commented property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("commented")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("comments")]
        public ISubmission Commented
        {
            get
            {
                return ModelHelper.CastAs<ISubmission>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The likedBy property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DisplayNameAttribute("likedBy")]
        [CategoryAttribute("Comment")]
        [XmlElementNameAttribute("likedBy")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("likes")]
        [ConstantAttribute()]
        public ISetExpression<IUser> LikedBy
        {
            get
            {
                return this._likedBy;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CommentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2018/social_media#//Comment")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Commented property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CommentedChanging;
        
        /// <summary>
        /// Gets fired when the Commented property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CommentedChanged;
        
        private static ITypedElement RetrieveCommentedReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2018.LiveContest.SocialNetwork.Comment.ClassInstance)).Resolve("commented")));
        }
        
        /// <summary>
        /// Raises the CommentedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCommentedChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CommentedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            ISubmission oldCommented = ModelHelper.CastAs<ISubmission>(oldParent);
            ISubmission newCommented = ModelHelper.CastAs<ISubmission>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldCommented, newCommented);
            this.OnCommentedChanging(e);
            this.OnPropertyChanging("Commented", e, _commentedReference);
        }
        
        /// <summary>
        /// Raises the CommentedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCommentedChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CommentedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            ISubmission oldCommented = ModelHelper.CastAs<ISubmission>(oldParent);
            ISubmission newCommented = ModelHelper.CastAs<ISubmission>(newParent);
            if ((oldCommented != null))
            {
                oldCommented.Comments.Remove(this);
            }
            if ((newCommented != null))
            {
                newCommented.Comments.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldCommented, newCommented);
            this.OnCommentedChanged(e);
            this.OnPropertyChanged("Commented", e, _commentedReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        private static ITypedElement RetrieveLikedByReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2018.LiveContest.SocialNetwork.Comment.ClassInstance)).Resolve("likedBy")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LikedBy property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LikedByCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("LikedBy", e, _likedByReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LikedBy property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LikedByCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LikedBy", e, _likedByReference);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "COMMENTED"))
            {
                return this.Commented;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LIKEDBY"))
            {
                return this._likedBy;
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
            if ((feature == "COMMENTED"))
            {
                this.Commented = ((ISubmission)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "COMMENTED"))
            {
                return new CommentedProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2018/social_media#//Comment")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Comment class
        /// </summary>
        public class CommentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Comment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CommentReferencedElementsCollection(Comment parent)
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
                    if ((this._parent.Commented != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.LikedBy.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CommentedChanged += this.PropagateValueChanges;
                this._parent.LikedBy.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CommentedChanged -= this.PropagateValueChanges;
                this._parent.LikedBy.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Commented == null))
                {
                    ISubmission commentedCasted = item.As<ISubmission>();
                    if ((commentedCasted != null))
                    {
                        this._parent.Commented = commentedCasted;
                        return;
                    }
                }
                IUser likedByCasted = item.As<IUser>();
                if ((likedByCasted != null))
                {
                    this._parent.LikedBy.Add(likedByCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Commented = null;
                this._parent.LikedBy.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Commented))
                {
                    return true;
                }
                if (this._parent.LikedBy.Contains(item))
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
                if ((this._parent.Commented != null))
                {
                    array[arrayIndex] = this._parent.Commented;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> likedByEnumerator = this._parent.LikedBy.GetEnumerator();
                try
                {
                    for (
                    ; likedByEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = likedByEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    likedByEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Commented == item))
                {
                    this._parent.Commented = null;
                    return true;
                }
                IUser userItem = item.As<IUser>();
                if (((userItem != null) 
                            && this._parent.LikedBy.Remove(userItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Commented).Concat(this._parent.LikedBy).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the commented property
        /// </summary>
        private sealed class CommentedProxy : ModelPropertyChange<IComment, ISubmission>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CommentedProxy(IComment modelElement) : 
                    base(modelElement, "commented")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISubmission Value
            {
                get
                {
                    return this.ModelElement.Commented;
                }
                set
                {
                    this.ModelElement.Commented = value;
                }
            }
        }
    }
}

