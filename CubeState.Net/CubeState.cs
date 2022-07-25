namespace CubeState.Net;

public class CubeState
{
    private int[] cp;
    private int[] ep;
    private int[] co;
    private int[] eo;

    public CubeState()
    {
        cp = Enumerable.Range(0, 8).ToArray();
        co = new int[cp.Length];
        ep = Enumerable.Range(0, 12).ToArray();
        eo = new int[ep.Length];
    }

    public int[] GetCornerPermutationState => cp;
    public int[] GetEdgPermutationState => ep;
    public int[] GetCornerOrientations => co;
    public int[] GetEdgeOrientations => eo;

    public bool CornerIsSolved()
    {
        for (int i = 0; i < cp.Length; i++)
            if (cp[i] != i)
                return false;
        if (co.Any(c => c != 0))
            return false;
        return true;
    }

    public bool EdgesIsSolved()
    {
        for (int i = 0; i < ep.Length; i++)
            if (ep[i] != i)
                return false;
        if (eo.Any(e => e != 0))
            return false;
        return true;
    }


    public bool IsSolved() => CornerIsSolved() && EdgesIsSolved();

    public void DoManyTurns(string turns)
    {
        foreach (var turn in turns.Split(" "))
            DoTurn(turn);
    }

    public void DoTurn(string turn)
    {
        switch (turn)
        {
            case "U":
                U_CW();
                break;
            case "U2":
                U_CW();
                U_CW();
                break;
            case "U'":
                U_CCW();
                break;
            case "D":
                D_CW();
                break;
            case "D2":
                D_CW();
                D_CW();
                break;
            case "D'":
                D_CCW();
                break;
            case "R":
                R_CW();
                break;
            case "R2":
                R_CW();
                R_CW();
                break;
            case "R'":
                R_CCW();
                break;
            case "L":
                L_CW();
                break;
            case "L2":
                L_CW();
                L_CW();
                break;
            case "L'":
                L_CCW();
                break;
            case "F":
                F_CW();
                break;
            case "F2":
                F_CW();
                F_CW();
                break;
            case "F'":
                F_CCW();
                break;
            case "B":
                B_CW();
                break;
            case "B2":
                B_CW();
                B_CW();
                break;
            case "B'":
                B_CCW();
                break;
            default:
                break;
        }
    }

    private void TwistCornersCW(int[] pieces) => TwistCW(pieces, cp);
    private void TwistEdgesCW(int[] pieces) => TwistCW(pieces, ep);
    private void TwistCornersCCW(int[] pieces) => TwistCCW(pieces, cp);
    private void TwistEdgesCCW(int[] pieces) => TwistCCW(pieces, ep);

    private void TwistCW(int[] pieces, int[] state)
    {
        var temp = state[pieces[3]];
        state[pieces[3]] = state[pieces[2]];
        state[pieces[2]] = state[pieces[1]];
        state[pieces[1]] = state[pieces[0]];
        state[pieces[0]] = temp;
    }

    private void TwistCCW(int[] pieces, int[] state)
    {
        var temp = state[pieces[0]];
        state[pieces[0]] = state[pieces[1]];
        state[pieces[1]] = state[pieces[2]];
        state[pieces[2]] = state[pieces[3]];
        state[pieces[3]] = temp;
    }

    private void FlipEdges(int[] edges)
    {
        foreach (var edge in edges)
        {
            if (eo[ep[edge]] == 0)
                eo[ep[edge]] = 1;
            else
                eo[ep[edge]] = 0;
        }
    }

    private void RotateCornesCW(int[] corners)
    {
        foreach (var corner in corners)
            if (co[cp[corner]] == 2)
                co[cp[corner]] = 0;
            else
                co[cp[corner]]++;
    }

    private void RotateCornesCCW(int[] corners)
    {
        foreach (var corner in corners)
            if (co[cp[corner]] == 0)
                co[cp[corner]] = 2;
            else
                co[cp[corner]]--;
    }

    public void U_CW()
    {
        TwistCornersCW(new int[] { 0, 1, 2, 3 });
        TwistEdgesCW(new int[] { 0, 1, 2, 3 });
    }
    public void U_CCW()
    {
        TwistCornersCCW(new int[] { 0, 1, 2, 3 });
        TwistEdgesCCW(new int[] { 0, 1, 2, 3 });
    }
    public void D_CW()
    {
        TwistCornersCW(new int[] { 7, 6, 5, 4 });
        TwistEdgesCW(new int[] { 11, 10, 9, 8 });
    }
    public void D_CCW()
    {
        TwistCornersCCW(new int[] { 7, 6, 5, 4 });
        TwistEdgesCCW(new int[] { 11, 10, 9, 8 });
    }
    public void R_CW()
    {
        TwistCornersCW(new int[] { 3, 2, 6, 7 });
        TwistEdgesCW(new int[] { 3, 6, 11, 7 });
        RotateCornesCW(new int[] { 2, 7 });
        RotateCornesCCW(new int[] { 3, 6 });
    }
    public void R_CCW()
    {
        TwistCornersCCW(new int[] { 3, 2, 6, 7 });
        TwistEdgesCCW(new int[] { 3, 6, 11, 7 });
        RotateCornesCCW(new int[] { 3, 6 });
        RotateCornesCW(new int[] { 2, 7 });
    }
    public void L_CW()
    {
        TwistCornersCW(new int[] { 0, 4, 5, 1 });
        TwistEdgesCW(new int[] { 1, 4, 9, 5 });
        RotateCornesCW(new int[] { 0, 5 });
        RotateCornesCCW(new int[] { 1, 4 });
    }
    public void L_CCW()
    {
        TwistCornersCCW(new int[] { 0, 4, 5, 1 });
        TwistEdgesCCW(new int[] { 1, 4, 9, 5 });
        RotateCornesCCW(new int[] { 1, 4 });
        RotateCornesCW(new int[] { 0, 5 });
    }
    public void F_CW()
    {
        TwistCornersCW(new int[] { 0, 3, 7, 4 });
        TwistEdgesCW(new int[] { 0, 7, 8, 4 });
        RotateCornesCW(new int[] { 3, 4 });
        RotateCornesCCW(new int[] { 0, 7 });
        FlipEdges(new int[] { 0, 4, 7, 8 });
    }
    public void F_CCW()
    {
        TwistCornersCCW(new int[] { 0, 3, 7, 4 });
        TwistEdgesCCW(new int[] { 0, 7, 8, 4 });
        RotateCornesCCW(new int[] { 0, 7 });
        RotateCornesCW(new int[] { 3, 4 });
        FlipEdges(new int[] { 0, 4, 7, 8 });
    }

    public void B_CW()
    {
        TwistCornersCW(new int[] { 1, 5, 6, 2 });
        TwistEdgesCW(new int[] { 2, 5, 10, 6 });
        RotateCornesCW(new int[] { 1, 6 });
        RotateCornesCCW(new int[] { 2, 5 });
        FlipEdges(new int[] { 2, 5, 6, 10 });
    }
    public void B_CCW()
    {
        TwistCornersCW(new int[] { 1, 2, 6, 5 });
        TwistEdgesCW(new int[] { 2, 6, 10, 5 });
        RotateCornesCCW(new int[] { 2, 5 });
        RotateCornesCW(new int[] { 1, 6 });
        FlipEdges(new int[] { 2, 5, 6, 10 });
    }

}