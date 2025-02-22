/**
 */
package ttc2019.live.changes.impl;

import org.eclipse.emf.common.notify.Notification;

import org.eclipse.emf.ecore.EClass;

import org.eclipse.emf.ecore.impl.ENotificationImpl;

import ttc2019.live.changes.AttributeListInsertion;
import ttc2019.live.changes.ChangesPackage;

/**
 * <!-- begin-user-doc -->
 * An implementation of the model object '<em><b>Attribute List Insertion</b></em>'.
 * <!-- end-user-doc -->
 * <p>
 * The following features are implemented:
 * </p>
 * <ul>
 *   <li>{@link ttc2019.live.changes.impl.AttributeListInsertionImpl#getAddedValue <em>Added Value</em>}</li>
 *   <li>{@link ttc2019.live.changes.impl.AttributeListInsertionImpl#getIndex <em>Index</em>}</li>
 * </ul>
 *
 * @generated
 */
public class AttributeListInsertionImpl extends AttributeChangeImpl implements AttributeListInsertion {
	/**
	 * The default value of the '{@link #getAddedValue() <em>Added Value</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getAddedValue()
	 * @generated
	 * @ordered
	 */
	protected static final String ADDED_VALUE_EDEFAULT = null;

	/**
	 * The cached value of the '{@link #getAddedValue() <em>Added Value</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getAddedValue()
	 * @generated
	 * @ordered
	 */
	protected String addedValue = ADDED_VALUE_EDEFAULT;

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
	protected AttributeListInsertionImpl() {
		super();
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	protected EClass eStaticClass() {
		return ChangesPackage.Literals.ATTRIBUTE_LIST_INSERTION;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public String getAddedValue() {
		return addedValue;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void setAddedValue(String newAddedValue) {
		String oldAddedValue = addedValue;
		addedValue = newAddedValue;
		if (eNotificationRequired())
			eNotify(new ENotificationImpl(this, Notification.SET, ChangesPackage.ATTRIBUTE_LIST_INSERTION__ADDED_VALUE, oldAddedValue, addedValue));
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
			eNotify(new ENotificationImpl(this, Notification.SET, ChangesPackage.ATTRIBUTE_LIST_INSERTION__INDEX, oldIndex, index));
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public Object eGet(int featureID, boolean resolve, boolean coreType) {
		switch (featureID) {
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__ADDED_VALUE:
				return getAddedValue();
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__INDEX:
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
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__ADDED_VALUE:
				setAddedValue((String)newValue);
				return;
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__INDEX:
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
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__ADDED_VALUE:
				setAddedValue(ADDED_VALUE_EDEFAULT);
				return;
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__INDEX:
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
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__ADDED_VALUE:
				return ADDED_VALUE_EDEFAULT == null ? addedValue != null : !ADDED_VALUE_EDEFAULT.equals(addedValue);
			case ChangesPackage.ATTRIBUTE_LIST_INSERTION__INDEX:
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
		result.append(" (addedValue: ");
		result.append(addedValue);
		result.append(", index: ");
		result.append(index);
		result.append(')');
		return result.toString();
	}

} //AttributeListInsertionImpl
