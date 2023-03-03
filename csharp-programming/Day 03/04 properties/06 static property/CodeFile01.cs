namespace training_basic_csharp {
    class ChessBoard {
        public int RowNo { get; set; }
        public int ColNo { get; set; }
        public static int BlockSize { get; set; } //it is static bz blocksize of all 64 blocks is same.
    }
    class Program {
        static void Main() {
            ChessBoard.BlockSize = 100;
            int blockSize = ChessBoard.BlockSize;
        }
    }
}
