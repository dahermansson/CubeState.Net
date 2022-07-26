namespace CubeState.Net.Tests;

public class CubeStateTests
    {
        [Fact]
        public void U4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.U_CW();
            testCubeState.U_CW();
            testCubeState.U_CW();
            testCubeState.U_CW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void UCCW4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.U_CCW();
            testCubeState.U_CCW();
            testCubeState.U_CCW();
            testCubeState.U_CCW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void D4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.D_CW();
            testCubeState.D_CW();
            testCubeState.D_CW();
            testCubeState.D_CW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void D_CCW4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.D_CCW();
            testCubeState.D_CCW();
            testCubeState.D_CCW();
            testCubeState.D_CCW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void R4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.R_CW();
            testCubeState.R_CW();
            testCubeState.R_CW();
            testCubeState.R_CW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void R_CCW4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.R_CCW();
            testCubeState.R_CCW();
            testCubeState.R_CCW();
            testCubeState.R_CCW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void L4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.L_CW();
            testCubeState.L_CW();
            testCubeState.L_CW();
            testCubeState.L_CW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void F4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.F_CW();
            testCubeState.F_CW();
            testCubeState.F_CW();
            testCubeState.F_CW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void B4()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.B_CW();
            testCubeState.B_CW();
            testCubeState.B_CW();
            testCubeState.B_CW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void R_CW_R_CCW()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.R_CW();
            testCubeState.R_CCW();

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void U_CW()
        {

            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.U_CW();

            Assert.Equal(new int[] { 3, 0, 1, 2, 4, 5, 6, 7 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 3, 0, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11 }, testCubeState.GetEdgePermutation);
        }
        [Fact]
        public void U_CCW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.U_CCW();

            Assert.Equal(new int[] { 1, 2, 3, 0, 4, 5, 6, 7 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11 }, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void D_CW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.D_CW();

            Assert.Equal(new int[] { 0, 1, 2, 3, 5, 6, 7, 4 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9, 10, 11, 8 }, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void D_CCW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.D_CCW();

            Assert.Equal(new int[] { 0, 1, 2, 3, 7, 4, 5, 6 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 11, 8, 9, 10 }, testCubeState.GetEdgePermutation);
        }
        [Fact]
        public void R_CW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.R_CW();

            Assert.Equal(new int[] { 0, 1, 3, 7, 4, 5, 2, 6 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 0, 1, 2, 7, 4, 5, 3, 11, 8, 9, 10, 6 }, testCubeState.GetEdgePermutation);
        }
        [Fact]
        public void R_CCW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.R_CCW();

            Assert.Equal(new int[] { 0, 1, 6, 2, 4, 5, 7, 3 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 0, 1, 2, 6, 4, 5, 11, 3, 8, 9, 10, 7 }, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void F_CW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.F_CW();

            Assert.Equal(new int[] { 4, 1, 2, 0, 7, 5, 6, 3 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 4, 1, 2, 3, 8, 5, 6, 0, 7, 9, 10, 11 }, testCubeState.GetEdgePermutation);

        }
        [Fact]
        public void F_CCW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.F_CCW();

            Assert.Equal(new int[] { 3, 1, 2, 7, 0, 5, 6, 4 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 7, 1, 2, 3, 0, 5, 6, 8, 4, 9, 10, 11 }, testCubeState.GetEdgePermutation);
        }

        [Fact]
        public void B_CW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.B_CW();

            Assert.Equal(new int[] { 0, 2, 6, 3, 4, 1, 5, 7 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 0, 1, 6, 3, 4, 2, 10, 7, 8, 9, 5, 11 }, testCubeState.GetEdgePermutation);
            Assert.Equal(new int[] { 0, 2, 1, 0, 0, 1, 2, 0 }, testCubeState.GetCornerOrientation);
            Assert.Equal(new int[] { 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0 }, testCubeState.GetEdgeOrientation);
        }

        [Fact]
        public void B_CCW()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.B_CCW();

            Assert.Equal(new int[] { 0, 5, 1, 3, 4, 6, 2, 7 }, testCubeState.GetCornerPermutation);
            Assert.Equal(new int[] { 0, 1, 5, 3, 4, 10, 2, 7, 8, 9, 6, 11 }, testCubeState.GetEdgePermutation);
            Assert.Equal(new int[] { 0, 2, 1, 0, 0, 1, 2, 0 }, testCubeState.GetCornerOrientation);
            Assert.Equal(new int[] { 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0 }, testCubeState.GetEdgeOrientation);
        }

        [Fact]
        public void SuperFlip()
        {
            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.DoManyTurns("U R2 F B R B2 R U2 L B2 R U' D' R2 F R' L B2 U2 F2");

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);
            Assert.Equal(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, testCubeState.GetEdgeOrientation);
        }

        [Fact]
        public void SuperFlipX2()
        {
            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.DoManyTurns("U R2 F B R B2 R U2 L B2 R U' D' R2 F R' L B2 U2 F2");
            testCubeState.DoManyTurns("U R2 F B R B2 R U2 L B2 R U' D' R2 F R' L B2 U2 F2");

            Assert.Equal(solvedCubeState.GetCornerPermutation, testCubeState.GetCornerPermutation);
            Assert.Equal(solvedCubeState.GetEdgePermutation, testCubeState.GetEdgePermutation);
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);
            Assert.Equal(solvedCubeState.GetEdgeOrientation, testCubeState.GetEdgeOrientation);
        }

        [Fact]
        public void CornerRotation_FR()
        {
            CubeState testCubeState = new CubeState();
            testCubeState.F_CW();
            Assert.Equal(1, testCubeState.GetCornerOrientation[0]);
            Assert.Equal(2, testCubeState.GetCornerOrientation[4]);
            Assert.Equal(2, testCubeState.GetCornerOrientation[3]);
            Assert.Equal(1, testCubeState.GetCornerOrientation[7]);

            testCubeState.R_CW();
            Assert.Equal(2, testCubeState.GetCornerOrientation[0]);
            Assert.Equal(1, testCubeState.GetCornerOrientation[3]);
        }

        [Fact]
        public void CornerRotationlAllMoveBackAndForward()
        {
            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();

            testCubeState.DoTurn("U");
            testCubeState.DoTurn("U'");
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);

            testCubeState.DoTurn("D");
            testCubeState.DoTurn("D'");
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);

            testCubeState.DoTurn("R");
            testCubeState.DoTurn("R'");
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);

            testCubeState.DoTurn("L");
            testCubeState.DoTurn("L'");
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);

            testCubeState.DoTurn("F");
            testCubeState.DoTurn("F'");
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);

            testCubeState.DoTurn("B");
            testCubeState.DoTurn("B'");
            Assert.Equal(solvedCubeState.GetCornerOrientation, testCubeState.GetCornerOrientation);
        }

        [Fact]
        public void ScrambleAndSolve()
        {
            var solvedCubeState = new CubeState();
            CubeState testCubeState = new CubeState();
            testCubeState.DoManyTurns("R U R' F' R U R' U' R' F R2 U' R' U'");
            testCubeState.DoManyTurns("U R U F' R' F U F' R F U2 R'");
            Assert.True(testCubeState.IsSolved());
        }
    }