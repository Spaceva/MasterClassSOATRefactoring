package kata.space;

import java.util.ArrayList;
import java.util.List;

public class Space {
    private final List<Dot> dots = new ArrayList<>();

    public void add(List<Dot> dots) {
        this.dots.addAll(dots);
    }

    public void clear() {
        this.dots.clear();
    }

    public boolean isStraightLine() {
        if (this.dots.size() < 2) {
            return false;
        }

        if (this.dots.size() == 2) {
            return true;
        }

        double deltaX = this.dots.get(1).getX() - this.dots.get(0).getX();
        double deltaY = this.dots.get(1).getY() - this.dots.get(0).getY();
        double deltaZ = this.dots.get(1).getZ() - this.dots.get(0).getZ();

        for (int index = 1; index < this.dots.size(); index++) {
            Dot currentDot = this.dots.get(index);
            Dot previousDot = this.dots.get(index - 1);

            double currentDeltaX = currentDot.getX() - previousDot.getX();
            double currentDeltaY = currentDot.getY() - previousDot.getY();
            double currentDeltaZ = currentDot.getZ() - previousDot.getZ();

            double coeffX = deltaX == 0 ? currentDeltaX : currentDeltaX / deltaX;
            double coeffY = deltaY == 0 ? currentDeltaY : currentDeltaY / deltaY;
            double coeffZ = deltaZ == 0 ? currentDeltaZ : currentDeltaZ / deltaZ;

            if (coeffX != coeffY || coeffX != coeffZ || coeffY != coeffZ) {
                return false;
            }
        }

        return true;
    }

    public boolean isEquilateralTriangle() {
        if (this.dots.size() != 3) {
            return false;
        }

        double deltaX01 = this.dots.get(1).getX() - this.dots.get(0).getX();
        double deltaY01 = this.dots.get(1).getY() - this.dots.get(0).getY();
        double deltaZ01 = this.dots.get(1).getZ() - this.dots.get(0).getZ();

        double deltaX12 = this.dots.get(2).getX() - this.dots.get(1).getX();
        double deltaY12 = this.dots.get(2).getY() - this.dots.get(1).getY();
        double deltaZ12 = this.dots.get(2).getZ() - this.dots.get(1).getZ();

        double deltaX20 = this.dots.get(0).getX() - this.dots.get(2).getX();
        double deltaY20 = this.dots.get(0).getY() - this.dots.get(2).getY();
        double deltaZ20 = this.dots.get(0).getZ() - this.dots.get(2).getZ();

        // On compare ici les distances au carré pour éviter les problèmes d'arrondi avec Math.sqrt
        double squareDistance01 = (Math.pow(deltaX01, 2) + Math.pow(deltaY01, 2) + Math.pow(deltaZ01, 2));
        double squareDistance12 = (Math.pow(deltaX12, 2) + Math.pow(deltaY12, 2) + Math.pow(deltaZ12, 2));
        double squareDistance20 = (Math.pow(deltaX20, 2) + Math.pow(deltaY20, 2) + Math.pow(deltaZ20, 2));

        return squareDistance01 == squareDistance12 && squareDistance12 == squareDistance20;
    }

    public boolean isSquareTriangle() {
        if (this.dots.size() != 3) {
            return false;
        }

        double deltaX01 = this.dots.get(1).getX() - this.dots.get(0).getX();
        double deltaY01 = this.dots.get(1).getY() - this.dots.get(0).getY();
        double deltaZ01 = this.dots.get(1).getZ() - this.dots.get(0).getZ();

        double deltaX12 = this.dots.get(2).getX() - this.dots.get(1).getX();
        double deltaY12 = this.dots.get(2).getY() - this.dots.get(1).getY();
        double deltaZ12 = this.dots.get(2).getZ() - this.dots.get(1).getZ();

        double deltaX20 = this.dots.get(0).getX() - this.dots.get(2).getX();
        double deltaY20 = this.dots.get(0).getY() - this.dots.get(2).getY();
        double deltaZ20 = this.dots.get(0).getZ() - this.dots.get(2).getZ();

        double squareDistance01 = Math.pow(deltaX01, 2) + Math.pow(deltaY01, 2) + Math.pow(deltaZ01, 2);
        double squareDistance12 = Math.pow(deltaX12, 2) + Math.pow(deltaY12, 2) + Math.pow(deltaZ12, 2);
        double squareDistance20 = Math.pow(deltaX20, 2) + Math.pow(deltaY20, 2) + Math.pow(deltaZ20, 2);


        return (squareDistance01) == ((squareDistance12) + (squareDistance20))
                || (squareDistance12) == ((squareDistance20) + (squareDistance01))
                || (squareDistance20) == ((squareDistance12) + (squareDistance01));
    }
}