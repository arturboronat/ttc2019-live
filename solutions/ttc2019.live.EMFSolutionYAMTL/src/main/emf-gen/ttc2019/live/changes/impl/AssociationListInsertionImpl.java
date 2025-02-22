/**
 */
package ttc2019.live.changes.impl;

import org.eclipse.emf.common.notify.Notification;

import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EObject;
import org.eclipse.emf.ecore.InternalEObject;

import org.eclipse.emf.ecore.impl.ENotificationImpl;

import ttc2019.live.changes.AssociationListInsertion;
import ttc2019.live.changes.ChangesPackage;

/**
 * <!-- begin-user-doc -->
 * An implementation of the model object '<em><b>Association List Insertion</b></em>'.
 * <!-- end-user-doc -->
 * <p>
 * The following features are implemented:
 * </p>
 * <ul>
 *   <li>{@link ttc2019.live.changes.impl.AssociationListInsertionImpl#getAddedElement <em>Added Element</em>}</li>
 *   <li>{@link ttc2019.live.changes.impl.AssociationListInsertionImpl#getIndex <em>Index</em>}</li>
 * </ul>
 *
 * @generated
 */
public class AssociationListInsertionImpl extends AssociationChangeImpl implements AssociationListInsertion {
	/**
	 * The cached value of the '{@link #getAddedElement() <em>Added Element</em>}' reference.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getAddedElement()
	 * @generated
	 * @ordered
	 */
	protected EObject addedElement;

	/**
	 * The default value of the '{@link #getIndex() <em>Index</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getIndex()
	 * @generated
	 * @ordered
	 */
	protected static final int INDEX_EDEFAULT = 0;

	/**
	 * The cached value of the '{@link #getIndex() <em>Index</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getIndex()
	 * @generated
	 * @ordered
	 */
	protected int index = INDEX_EDEFAULT;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	protected AssociationListInsertionImpl() {
		super();
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	protected EClass eStaticClass() {
		return ChangesPackage.Literals.ASSOCIATION_LIST_INSERTION;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public EObject getAddedElement() {
		if (addedElement != null && addedElement.eIsProxy()) {
			InternalEObject oldAddedElement = (InternalEObject)addedElement;
			addedElement = eResolveProxy(oldAddedElement);
			if (addedElement != oldAddedElement) {
				if (eNotificationRequired())
					eNotify(new ENotificationImpl(this, Notification.RESOLVE, ChangesPackage.ASSOCIATION_LIST_INSERTION__ADDED_ELEMENT, oldAddedElement, addedElement));
			}
		}
		return addedElement;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EObject basicGetAddedElement() {
		return addedElement;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void setAddedElement(EObject newAddedElement) {
		EObject oldAddedElement = addedElement;
		addedElement = newAddedElement;
		if (eNotificationRequired())
			eNotify(new ENotificationImpl(this, Notification.SET, ChangesPackage.ASSOCIATION_LIST_INSERTION__ADDED_ELEMENT, oldAddedElement, addedElement));
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public int getIndex() {
		return index;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void setIndex(int newIndex) {
		int oldIndex = index;
		index = newIndex;
		if (eNotificationRequired())
			eNotify(new ENotificationImpl(this, Notification.SET, ChangesPackage.ASSOCIATION_LIST_INSERTION__INDEX, oldIndex, index));
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public Object eGet(int featureID, boolean resolve, boolean coreType) {
		switch (featureID) {
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__ADDED_ELEMENT:
				if (resolve) return getAddedElement();
				return basicGetAddedElement();
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__INDEX:
				return getIndex();
		}
		return super.eGet(featureID, resolve, coreType);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void eSet(int featureID, Object newValue) {
		switch (featureID) {
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__ADDED_ELEMENT:
				setAddedElement((EObject)newValue);
				return;
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__INDEX:
				setIndex((Integer)newValue);
				return;
		}
		super.eSet(featureID, newValue);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void eUnset(int featureID) {
		switch (featureID) {
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__ADDED_ELEMENT:
				setAddedElement((EObject)null);
				return;
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__INDEX:
				setIndex(INDEX_EDEFAULT);
				return;
		}
		super.eUnset(featureID);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public boolean eIsSet(int featureID) {
		switch (featureID) {
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__ADDED_ELEMENT:
				return addedElement != null;
			case ChangesPackage.ASSOCIATION_LIST_INSERTION__INDEX:
				return index != INDEX_EDEFAULT;
		}
		return super.eIsSet(featureID);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public String toString() {
		if (eIsProxy()) return super.toString();

		StringBuilder result = new StringBuilder(super.toString());
		result.append(" (index: ");
		result.append(index);
		result.append(')');
		return result.toString();
	}

} //AssociationListInsertionImpl
