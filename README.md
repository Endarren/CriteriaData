# CriteriaData
A base scriptable object that can be used to see if an object mets certain criteria in Unity3D.

# How to Create

Right-click in the Project Tab.  In the pop up, go to Create -> Endar Scripts -> Criteria and pick the one you want to use.

# How to Use

CriteriaDataBase has a method called MetsCriteria.  Send the object you want checked as a parameter into this method.  The method will return true if the object mets the specified criteria.

# Included Criteria

* CriteriaData - Checks if a GameObject has a certain tag and/or is on a layer.

* RigidbodyCriteriaData - Checks a GameObject to see if its RigidBody has velocity, angular velocity, mass, gravity, and/or kinematic settings matching the required settings.

* CompoundCriteria - Checks if an object mets a minimum number of other CriteriaData.


# Extendable

You can make your own CriteriaData scripts by inheriting from CriteriaDataBase.
