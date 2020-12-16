package kata.employee;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.assertThat;
import static org.assertj.core.api.Assertions.catchThrowable;

class EmployeeTest {
    @Test
    public void GetAreaCode_Should_ReturnAreaCode_When_ValidPhoneNumber() throws Exception {
        Employee employee = new Employee(
                "Jean",
                "Dupont",
                1,
                "+33-1-23-45-67-89",
                "1707533123456"
        );

        assertThat(employee.getAreaCode()).isEqualTo("+33");
    }

    @Test
    public void GetAreaCode_Should_ThrowException_When_InvalidPhoneNumber() {
        Employee employee = new Employee(
                "Jean",
                "Dupont",
                1,
                "+33123456789",
                "1707533123456"
        );

        final Throwable throwable = catchThrowable(employee::getAreaCode);

        assertThat(throwable).isNotNull();
    }

    @Test
    public void GetBirthYear_Should_ReturnAreaCode_When_ValidSecuritySocialNumber() throws Exception {
        Employee employee = new Employee(
                "Jean",
                "Dupont",
                1,
                "+33-1-23-45-67-89",
                "1707533123456"
        );

        assertThat(employee.getBirthYear()).isEqualTo("70");
    }

    @Test
    public void GetBirthYear_Should_ThrowException_When_InvalidSecuritySocialNumber() {
        Employee employee = new Employee(
                "Jean",
                "Dupont",
                1,
                "+33123456789",
                "1843123456"
        );

        final Throwable throwable = catchThrowable(employee::getAreaCode);

        assertThat(throwable).isNotNull();
    }

}