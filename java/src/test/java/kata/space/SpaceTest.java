package kata.space;

import org.junit.jupiter.api.Test;

import static java.util.Arrays.asList;
import static java.util.Collections.singletonList;
import static org.assertj.core.api.Assertions.assertThat;

class SpaceTest {
    @Test
    public void IsStraightLine_Should_ReturnFalse_When_OneDot() {
        Space space = new Space();
        space.add(singletonList(new Dot(1, 0, 1)));

        assertThat(space.isStraightLine()).isFalse();
    }

    @Test
    public void IsStraightLine_Should_ReturnTrue_When_TwoDots() {
        Space space = new Space();
        space.add(asList(
                new Dot(1, 0, 1),
                new Dot(1, 3, 2)
        ));

        assertThat(space.isStraightLine()).isTrue();
    }

    @Test
    public void IsStraightLine_Should_ReturnTrue_When_FourAlignedDots() {
        Space space = new Space();
        space.add(asList(
                new Dot(1, 0, 1),
                new Dot(3, -1, 2),
                new Dot(7, -3, 4),
                new Dot(9, -4, 5)
        ));

        assertThat(space.isStraightLine()).isTrue();
    }

    @Test
    public void IsStraightLine_Should_ReturnFalse_When_FourNonAlignedDots() {
        Space space = new Space();

        space.add(asList(
                new Dot(1, 0, 1),
                new Dot(3, 0, 2),
                new Dot(7, 0, 4),
                new Dot(9, 0, 7)
        ));

        assertThat(space.isStraightLine()).isFalse();
    }

    @Test
    public void IsEquilateralTriangle_Should_ReturnFalse_When_TwoDots() {
        Space space = new Space();
        space.add(asList(
                new Dot(1, 0, 1),
                new Dot(3, 0, 2)
        ));

        assertThat(space.isEquilateralTriangle()).isFalse();
    }

    @Test
    public void IsEquilateralTriangle_Should_ReturnTrue_When_ThreeDotsWellPositioned() {
        Space space = new Space();
        space.add(asList(
                new Dot(0, 0, 0),
                new Dot(3, Math.pow(6, 2) - Math.pow(3, 2), 0),
                new Dot(6, 0, 0)
        ));

        assertThat(space.isEquilateralTriangle()).isTrue();
    }

    @Test
    public void IsEquilateralTriangle_Should_ReturnFalse_When_ThreeDotsNotWellPositioned() {
        Space space = new Space();
        space.add(asList(
                new Dot(0, 0, 0),
                new Dot(3, 7, 0),
                new Dot(6, 0, 0)
        ));

        assertThat(space.isEquilateralTriangle()).isFalse();
    }

    @Test
    public void IsSquareTriangle_Should_ReturnFalse_When_TwoDots() {
        Space space = new Space();
        space.add(asList(
                new Dot(0, 0, 0),
                new Dot(6, 0, 0)
        ));

        assertThat(space.isSquareTriangle()).isFalse();
    }

    @Test
    public void IsSquareTriangle_Should_ReturnTrue_When_ThreeDotsWellPositioned() {
        Space space = new Space();
        space.add(asList(
                new Dot(3, 0, 0),
                new Dot(0, 0, 0),
                new Dot(0, 3, 0)
        ));

        assertThat(space.isSquareTriangle()).isTrue();
    }

    @Test
    public void IsSquareTriangle_Should_ReturnFalse_When_ThreeDotsNotWellPositioned() {
        Space space = new Space();
        space.add(asList(
                new Dot(1, 4, 0),
                new Dot(3, 7, 0),
                new Dot(9, 8, 0)
        ));

        assertThat(space.isSquareTriangle()).isFalse();
    }

}