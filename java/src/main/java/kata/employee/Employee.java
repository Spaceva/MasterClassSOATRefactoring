package kata.employee;

public class Employee {
    public String firstName;
    public String lastName;
    public int id;
    public String phoneNumber;
    public String securitySocialNumber;

    public Employee(String firstName, String lastName, int id, String phoneNumber, String securitySocialNumber) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.phoneNumber = phoneNumber;
        this.securitySocialNumber = securitySocialNumber;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getSecuritySocialNumber() {
        return securitySocialNumber;
    }

    public void setSecuritySocialNumber(String securitySocialNumber) {
        this.securitySocialNumber = securitySocialNumber;
    }

    public String getAreaCode() throws Exception {
        if (this.phoneNumber != null && this.phoneNumber != "" && this.phoneNumber.length() > 0 && this.phoneNumber.startsWith("+") && this.phoneNumber.indexOf("-") >= 0) {
            final String[] parts = this.phoneNumber.split("-");
            return parts[0];
        } else {
            throw new Exception("No correct phone number.");
        }
    }

    public String getBirthYear() throws Exception {
        if (this.securitySocialNumber != null && this.securitySocialNumber != "" && this.securitySocialNumber.length() == 13) {
            return this.securitySocialNumber.substring(1, 3);
        } else {
            throw new Exception("No Social Security Number");
        }
    }

}
