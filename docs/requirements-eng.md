# DVLD: Project 1 – Driving License Management

## Driving & Vehicle License Department (DVLD)

**System No. 1 – System for Issuing and Managing Driving Licenses**

The tasks of the Driving License Department vary from country to country, but generally include a set of common and essential tasks to organize and manage the process of granting driving licenses and ensuring safe drivers on the roads.

This document lists the simplified system requirements.

---

## Main Services Provided

1. First-time driving license issuance – Application fee: $5  
2. Retake test service – Application fee: $5  
3. Driving license renewal – Application fee: $5  
4. Replacement of lost license – Application fee: $5  
5. Replacement of damaged license – Application fee: $5  
6. Release of detained license – Application fee: $5  
7. International driving license issuance – Application fee: $5  

---

## Application Information

Each applicant must submit a request for the required service and pay its fee.

Application information includes:

- Application Number  
- Application Date  
- Applicant National Number (if the person is not in the system, they must be added first)  
- Application Type (based on service requested)  
- Application Status (New, Canceled, Completed)  
- Application Fees Paid  

**Special rule for New License Application:**  
- Must specify the requested license class.  
- Ensure applicant does not already hold the same class license.  
- Ensure there is no existing unfinished application of the same type.  

Each application must be linked to a person. Each person can have multiple applications.

---

## Applicant Information

Applicant’s personal information must be stored in the system and cannot be duplicated. Required fields:

- National Number  
- Full Name (four parts)  
- Date of Birth  
- Address  
- Phone Number  
- Email  
- Nationality  
- Personal Photo  

---

## Details of Services

### 1. First-Time Driving License Issuance

Applicant can apply for a specific license class. License classes:

1. **Class 1 – Small Motorcycle License**  
   - Allows driving small motorcycles.  
   - Age requirement: 18 years.  
   - License fee: $15 + application fee.  
   - Validity: 5 years.  

2. **Class 2 – Heavy Motorcycle License**  
   - Allows driving heavy and powerful motorcycles.  
   - Age requirement: 21 years.  
   - License fee: $30 + application fee.  
   - Validity: 5 years.  

3. **Class 3 – Regular Driving License (Car)**  
   - Allows driving light vehicles and personal cars.  
   - Age requirement: 18 years.  
   - License fee: $20 + application fee.  
   - Validity: 10 years.  

4. **Class 4 – Commercial Driving License (Taxi/Limousine)**  
   - Allows driving taxis and limousines.  
   - Age requirement: 21 years.  
   - License fee: $200 + application fee.  
   - Validity: 10 years.  

5. **Class 5 – Agricultural Vehicles License (Tractors, etc.)**  
   - Allows driving all agricultural vehicles.  
   - Age requirement: 21 years.  
   - License fee: $50 + application fee.  
   - Validity: 10 years.  

6. **Class 6 – Small and Medium Bus License**  
   - Allows driving small and medium buses.  
   - Age requirement: 21 years.  
   - License fee: $250 + application fee.  
   - Validity: 10 years.  

7. **Class 7 – Trucks and Heavy Vehicles License**  
   - Allows driving trucks and heavy vehicles (buses, large trucks).  
   - Age requirement: 21 years.  
   - License fee: $300 + application fee.  
   - Validity: 10 years.  

**System License Class Table must include:**  
- LicenseClassID  
- ClassName  
- ClassDescription  
- MinimumAllowedAge  
- ValidityLength (years)  
- ClassFees  

### Eligibility Conditions

- Applicant’s age must meet the minimum for the class. Otherwise, the system must reject the request.  
- Applicant must not already hold a license of the same class. Otherwise, system rejects.  
- Applicant can hold multiple licenses of different classes (e.g., car + motorcycle).  
- Applicant must submit valid identification documents (passport, national ID).  
- Applicant must provide certificate of completion of driving training courses before being eligible for tests.  

### Required Tests

Applicant must pass all tests in sequence:

1. **Medical / Vision Test**  
   - Appointment scheduled, fee: $10.  
   - Result recorded as Pass/Fail with date.  
   - If failed, applicant must correct vision (glasses/surgery) and schedule again.  

2. **Theoretical Test**  
   - Appointment scheduled manually by staff, fee: $20.  
   - Written exam outside system, result stored (out of 100, Pass/Fail).  
   - If failed, applicant must pay fee again and reschedule.  

3. **Practical Driving Test**  
   - Appointment scheduled manually, fee depends on license class.  
   - Applicant must demonstrate driving ability.  
   - If failed, applicant can retake by paying fee again and rescheduling.  

**After passing all tests:** License is issued with the following info:  
- License Number  
- License Holder Photo  
- National Number  
- Full Name  
- Date of Birth  
- License Class  
- Issue Date  
- Expiry Date  
- License Conditions / Notes  
- License Status (New, Renewal, Replacement Lost, Replacement Damaged)  

System must allow querying licenses by National Number or License Number.  
When any license is issued, the person becomes a “Registered Driver” with a Driver ID.  

---

### 2. Retake Test Service

- Allows scheduling a new test for failed applicants.  
- Requires entering previous test number.  
- Applicant must have failed previous test.  
- Fee: $5 + relevant test fee.  
- Appointment scheduled manually.  
- Retake request has its own Application Number but links to the original application.  
- Cannot schedule two appointments for same test.  

---

### 3. License Renewal Service

- Allows renewal of an existing license.  
- Fee: $10.  
- Requires new vision test appointment and passing it.  
- Applicant must hand in expired license first.  

---

### 4. Replacement for Lost License

- Allows issuing replacement for lost license.  
- System must check license is not detained.  
- Fee: $20.  
- Applicant must hand in old (expired) license if available.  

---

### 5. Replacement for Damaged License

- Allows issuing replacement for damaged license.  
- Applicant must hand in damaged license.  
- Fee: $20.  
- System must record replacement issue date.  

---

### 6. Release of Detained License

- Allows releasing detained license after paying fine.  
- Must record release date.  

---

### 7. International Driving License

- Allows issuing international license.  
- Validity defined in system (e.g., 1 year).  
- Available only to holders of valid Class 3 licenses.  
- License must not be expired or detained.  
- Fee: $20.  
- System must prevent issuing multiple active international licenses. If one exists, cancel it before issuing a new one.  
- All previously issued international licenses must be stored.  

---

## System Administration

### 1. Manage Users

- Add User (linked to a Person).  
- View User Information.  
- Edit User Information.  
- Delete User.  
- Freeze User Account.  
- Assign User Permissions.  

**User Information includes:**  
- National Number  
- Full Name  
- Date of Birth  
- Address  
- Phone Number  
- Email  
- Nationality  
- Personal Photo  
- Username  
- Password  

---

### 2. Manage People

- Search by National Number.  
- View Person Information.  
- Add New Person.  
- Edit Person Information.  
- Delete Person.  
- No duplicate persons with same National Number.  

**Person Information includes:**  
- National Number  
- Full Name  
- Date of Birth  
- Address  
- Phone Number  
- Email  
- Nationality  
- Personal Photo  

---

### 3. Manage Applications

- Search by Application Number.  
- Search by National Number.  
- View Applications List.  
- View Application Information (including fees).  
- Edit Application Information.  
- Filter by Status.  

---

### 4. Manage Test Types

- Test types are fixed.  
- Only fees can be modified.  

---

### 5. Manage License Classes

- Classes are fixed.  
- System must allow updating: minimum age, validity length, and fees.  

---

### 6. Manage License Detentions

- Must store: License Number, Reason for Detention, Date of Detention, Fine Amount.  
- Record which user performed the action and when.  

---
