using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.IO;

namespace FurEd {
	public static class Remapper {
		#region Remaps
		public static byte[][] FurRemap = new byte[][] {
            new byte[] { 199, 200, 201, 202, 203, 204, 205, 206 },
            new byte[] { 89, 90, 91, 92, 93, 94, 95, 174 },
            new byte[] { 204, 204, 205, 205, 206, 206, 207, 207 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 40, 42, 44, 47, 25, 28, 153, 152 },
            new byte[] { 146, 147, 149, 150, 151, 152, 153, 155 },
            new byte[] { 33, 34, 35, 36, 37, 12, 38, 20 },
            new byte[] { 177, 178, 179, 180, 181, 182, 148, 150 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 144, 145, 146, 148, 150, 152, 153, 154 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 10, 10, 11, 11, 12, 13, 14, 15 },
            new byte[] { 120, 192, 209, 193, 194, 213, 216, 219 },
            new byte[] { 162, 164, 166, 168, 170, 171, 173, 175 },
            new byte[] { 195, 196, 197, 198, 199, 200, 201, 202 },
            new byte[] { 232, 233, 234, 235, 236, 237, 238, 239 },
        };

		public static byte[][] MarkingsRemap = new byte[][] {
            new byte[] { 199, 200, 201, 202, 203, 204, 205, 206 },
            new byte[] { 89, 90, 91, 92, 93, 94, 95, 174 },
            new byte[] { 204, 204, 205, 205, 206, 206, 207, 207 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 40, 42, 44, 47, 25, 28, 153, 152 },
            new byte[] { 146, 147, 149, 150, 151, 152, 153, 155 },
            new byte[] { 33, 34, 35, 36, 37, 12, 38, 20 },
            new byte[] { 177, 178, 179, 180, 181, 182, 148, 150 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 144, 145, 146, 148, 150, 152, 153, 154 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 10, 10, 11, 11, 12, 13, 14, 15 },
            new byte[] { 120, 192, 209, 193, 194, 213, 216, 219 },
            new byte[] { 162, 164, 166, 168, 170, 171, 173, 175 },
            new byte[] { 195, 196, 197, 198, 199, 200, 201, 202 },
            new byte[] { 232, 233, 234, 235, 236, 237, 238, 239 },
        };

		public static byte[][] HairRemap = new byte[][] {
            new byte[] { 12, 13, 14, 15, 159, 159, 159, 159 },
            new byte[] { 10, 11, 12, 13, 14, 14, 14, 14 },
            new byte[] { 10, 10, 10, 11, 12, 12, 12, 12 },
            new byte[] { 34, 35, 240, 37, 38, 38, 38, 38 },
            new byte[] { 133, 134, 135, 158, 159, 159, 159, 159 },
            new byte[] { 37, 38, 39, 155, 156, 156, 156, 156 },
            new byte[] { 35, 36, 37, 38, 39, 39, 39, 39 },
            new byte[] { 33, 34, 35, 36, 37, 37, 37, 37 },
            new byte[] { 24, 26, 27, 154, 156, 156, 156, 156 },
            new byte[] { 19, 20, 21, 22, 23, 23, 23, 23 },
            new byte[] { 53, 54, 55, 61, 62, 62, 62, 62 },
            new byte[] { 49, 50, 51, 52, 53, 53, 53, 53 },
            new byte[] { 48, 49, 49, 50, 52, 52, 52, 52 },
            new byte[] { 48, 49, 241, 52, 53, 53, 53, 53 },
            new byte[] { 141, 56, 56, 57, 58, 58, 58, 58 },
            new byte[] { 68, 69, 70, 71, 79, 79, 79, 79 },
            new byte[] { 73, 74, 75, 76, 77, 77, 77, 77 },
            new byte[] { 64, 72, 73, 74, 75, 75, 75, 75 },
            new byte[] { 64, 64, 242, 66, 67, 67, 67, 67 },
            new byte[] { 244, 244, 244, 84, 85, 85, 85, 85 },
            new byte[] { 84, 85, 86, 87, 175, 175, 175, 175 },
            new byte[] { 83, 84, 85, 86, 87, 87, 87, 87 },
            new byte[] { 81, 82, 83, 84, 85, 85, 85, 85 },
            new byte[] { 234, 245, 245, 236, 237, 237, 237, 237 },
            new byte[] { 236, 237, 238, 239, 239, 239, 239, 239 },
            new byte[] { 228, 229, 230, 205, 206, 206, 206, 206 },
            new byte[] { 226, 227, 228, 229, 230, 230, 230, 230 },
            new byte[] { 224, 225, 226, 227, 228, 228, 228, 228 },
            new byte[] { 137, 242, 242, 67, 69, 69, 69, 69 },
            new byte[] { 235, 236, 237, 238, 239, 239, 239, 239 },
            new byte[] { 131, 132, 133, 134, 135, 135, 135, 135 },
            new byte[] { 129, 130, 131, 132, 133, 133, 133, 133 },
            new byte[] { 32, 128, 129, 130, 131, 131, 131, 131 },
            new byte[] { 97, 98, 99, 100, 101, 101, 101, 101 },
            new byte[] { 234, 234, 235, 236, 236, 236, 236, 236 },
            new byte[] { 109, 110, 111, 204, 205, 205, 205, 205 },
            new byte[] { 108, 109, 110, 111, 204, 204, 204, 204 },
            new byte[] { 107, 108, 109, 110, 111, 111, 111, 111 },
            new byte[] { 113, 114, 115, 116, 118, 118, 118, 118 },
            new byte[] { 173, 174, 175, 175, 207, 207, 207, 207 },
            new byte[] { 200, 202, 204, 205, 207, 207, 207, 207 },
            new byte[] { 195, 197, 198, 200, 202, 202, 202, 202 },
            new byte[] { 120, 209, 194, 216, 219, 219, 219, 219 },
            new byte[] { 144, 146, 150, 153, 154, 154, 154, 154 },
            new byte[] { 120, 122, 124, 126, 127, 127, 127, 127 },
        };

		public static byte[] EyeRemap = new byte[] {
            23, 37, 50, 52, 67, 83, 86, 110, 185, 234, 236, 238, 243, 244, 245, 150,
            153, 156, 207, 129, 10, 159, 90, 230, 240, 241, 242, 202, 127, 172
        };

		public static byte[] BadgeRemap = new byte[] {
            14, 12, 10, 240, 135, 39, 37, 35, 27, 21, 55, 51, 49, 241, 56, 70,
            75, 73, 242, 244, 86, 85, 83, 245, 238, 230, 228, 226, 242, 237, 133, 131,
            129, 99, 235, 111, 110, 109, 115, 175
        };

		public static byte[][] VestRemap = new byte[][] {
            new byte[] { 10, 10, 11, 12, 13, 14, 15, 15 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 24, 25, 26, 27, 28, 29, 30, 31 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 40, 41, 42, 43, 44, 45, 46, 47 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 56, 57, 58, 59, 60, 61, 62, 63 },
            new byte[] { 64, 65, 66, 67, 68, 69, 70, 71 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 88, 89, 90, 91, 92, 93, 94, 95 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 112, 113, 114, 115, 116, 117, 118, 119 },
            new byte[] { 120, 121, 122, 123, 124, 125, 126, 127 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 136, 137, 138, 139, 140, 141, 142, 143 },
            new byte[] { 144, 145, 146, 147, 148, 149, 150, 151 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 160, 161, 162, 163, 164, 165, 166, 167 },
            new byte[] { 168, 169, 170, 171, 172, 173, 174, 175 },
            new byte[] { 176, 177, 178, 179, 180, 181, 182, 183 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 192, 193, 194, 195, 196, 197, 198, 199 },
            new byte[] { 200, 201, 202, 203, 204, 205, 206, 207 },
            new byte[] { 120, 209, 210, 211, 212, 213, 214, 215 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 234, 234, 235, 236, 237, 238, 239, 239 },
            new byte[] { 88, 88, 89, 90, 90, 91, 91, 92 },
        };

		public static byte[][] BracersRemap = new byte[][] {
            new byte[] { 10, 10, 11, 12, 13, 14, 15, 15 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 24, 25, 26, 27, 28, 29, 30, 31 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 40, 41, 42, 43, 44, 45, 46, 47 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 56, 57, 58, 59, 60, 61, 62, 63 },
            new byte[] { 64, 65, 66, 67, 68, 69, 70, 71 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 88, 89, 90, 91, 92, 93, 94, 95 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 112, 113, 114, 115, 116, 117, 118, 119 },
            new byte[] { 120, 121, 122, 123, 124, 125, 126, 127 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 136, 137, 138, 139, 140, 141, 142, 143 },
            new byte[] { 144, 145, 146, 147, 148, 149, 150, 151 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 160, 161, 162, 163, 164, 165, 166, 167 },
            new byte[] { 168, 169, 170, 171, 172, 173, 174, 175 },
            new byte[] { 176, 177, 178, 179, 180, 181, 182, 183 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 192, 193, 194, 195, 196, 197, 198, 199 },
            new byte[] { 200, 201, 202, 203, 204, 205, 206, 207 },
            new byte[] { 120, 209, 210, 211, 212, 213, 214, 215 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 234, 234, 235, 236, 237, 238, 239, 239 },
            new byte[] { 88, 88, 89, 90, 90, 91, 91, 92 },
        };

		public static byte[][] CapeRemap = new byte[][] {
            new byte[] { 10, 10, 11, 12, 13, 14, 15, 15 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 24, 25, 26, 27, 28, 29, 30, 31 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 40, 41, 42, 43, 44, 45, 46, 47 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 56, 57, 58, 59, 60, 61, 62, 63 },
            new byte[] { 64, 65, 66, 67, 68, 69, 70, 71 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 88, 89, 90, 91, 92, 93, 94, 95 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 112, 113, 114, 115, 116, 117, 118, 119 },
            new byte[] { 120, 121, 122, 123, 124, 125, 126, 127 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 136, 137, 138, 139, 140, 141, 142, 143 },
            new byte[] { 144, 145, 146, 147, 148, 149, 150, 151 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 160, 161, 162, 163, 164, 165, 166, 167 },
            new byte[] { 168, 169, 170, 171, 172, 173, 174, 175 },
            new byte[] { 176, 177, 178, 179, 180, 181, 182, 183 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 192, 193, 194, 195, 196, 197, 198, 199 },
            new byte[] { 200, 201, 202, 203, 204, 205, 206, 207 },
            new byte[] { 120, 209, 210, 211, 212, 213, 214, 215 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 234, 234, 235, 236, 237, 238, 239, 239 },
            new byte[] { 88, 88, 89, 90, 90, 91, 91, 92 },
        };

		public static byte[][] BootRemap = new byte[][] {
            new byte[] { 10, 10, 11, 12, 13, 14, 15, 15 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 24, 25, 26, 27, 28, 29, 30, 31 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 40, 41, 42, 43, 44, 45, 46, 47 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 56, 57, 58, 59, 60, 61, 62, 63 },
            new byte[] { 64, 65, 66, 67, 68, 69, 70, 71 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 88, 89, 90, 91, 92, 93, 94, 95 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 112, 113, 114, 115, 116, 117, 118, 119 },
            new byte[] { 120, 121, 122, 123, 124, 125, 126, 127 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 136, 137, 138, 139, 140, 141, 142, 143 },
            new byte[] { 144, 145, 146, 147, 148, 149, 150, 151 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 160, 161, 162, 163, 164, 165, 166, 167 },
            new byte[] { 168, 169, 170, 171, 172, 173, 174, 175 },
            new byte[] { 176, 177, 178, 179, 180, 181, 182, 183 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 192, 193, 194, 195, 196, 197, 198, 199 },
            new byte[] { 200, 201, 202, 203, 204, 205, 206, 207 },
            new byte[] { 120, 209, 210, 211, 212, 213, 214, 215 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 234, 234, 235, 236, 237, 238, 239, 239 },
            new byte[] { 88, 88, 89, 90, 90, 91, 91, 92 },
        };

		public static byte[][] TrousersRemap = new byte[][] {
            new byte[] { 10, 10, 11, 12, 13, 14, 15, 15 },
            new byte[] { 16, 17, 18, 19, 20, 21, 22, 23 },
            new byte[] { 24, 25, 26, 27, 28, 29, 30, 31 },
            new byte[] { 32, 33, 34, 35, 36, 37, 38, 39 },
            new byte[] { 40, 41, 42, 43, 44, 45, 46, 47 },
            new byte[] { 48, 49, 50, 51, 52, 53, 54, 55 },
            new byte[] { 56, 57, 58, 59, 60, 61, 62, 63 },
            new byte[] { 64, 65, 66, 67, 68, 69, 70, 71 },
            new byte[] { 72, 73, 74, 75, 76, 77, 78, 79 },
            new byte[] { 80, 81, 82, 83, 84, 85, 86, 87 },
            new byte[] { 88, 89, 90, 91, 92, 93, 94, 95 },
            new byte[] { 96, 97, 98, 99, 100, 101, 102, 103 },
            new byte[] { 104, 105, 106, 107, 108, 109, 110, 111 },
            new byte[] { 112, 113, 114, 115, 116, 117, 118, 119 },
            new byte[] { 120, 121, 122, 123, 124, 125, 126, 127 },
            new byte[] { 128, 129, 130, 131, 132, 133, 134, 135 },
            new byte[] { 136, 137, 138, 139, 140, 141, 142, 143 },
            new byte[] { 144, 145, 146, 147, 148, 149, 150, 151 },
            new byte[] { 152, 153, 154, 155, 156, 157, 158, 159 },
            new byte[] { 160, 161, 162, 163, 164, 165, 166, 167 },
            new byte[] { 168, 169, 170, 171, 172, 173, 174, 175 },
            new byte[] { 176, 177, 178, 179, 180, 181, 182, 183 },
            new byte[] { 184, 185, 186, 187, 188, 189, 190, 191 },
            new byte[] { 192, 193, 194, 195, 196, 197, 198, 199 },
            new byte[] { 200, 201, 202, 203, 204, 205, 206, 207 },
            new byte[] { 120, 209, 210, 211, 212, 213, 214, 215 },
            new byte[] { 216, 217, 218, 219, 220, 221, 222, 223 },
            new byte[] { 224, 225, 226, 227, 228, 229, 230, 231 },
            new byte[] { 234, 234, 235, 236, 237, 238, 239, 239 },
            new byte[] { 88, 88, 89, 90, 90, 91, 91, 92 },
        };
		#endregion

		public static bool PalLoaded = false;
		public static Color[] Palette;

		public static FurcadiaShapes[] Players;
		public static FurcadiaShapes[] Portraits;

		public static string CleanupPath(string path) {
			string sepString = Path.DirectorySeparatorChar.ToString();
			if (path.EndsWith(sepString))
				return path;
			else
				return path + sepString;
		}

		public static string FindPatchPath() {
			string path = null;
			string sepString = Path.DirectorySeparatorChar.ToString();

			if (FurEd.Properties.Settings.Default.PatchPath != null) {
				path = FurEd.Properties.Settings.Default.PatchPath;
				if (Directory.Exists(path) && File.Exists(Path.Combine(path, "player.fsh")))
					return path;
			}

			try {
				path = (string)Microsoft.Win32.Registry.GetValue(
					@"HKEY_LOCAL_MACHINE\SOFTWARE\Dragon's Eye Productions\Furcadia\Patches",
					"default", null);

				if (path.Length > 0 && Directory.Exists(path) && File.Exists(Path.Combine(path, "player.fsh")))
					return path;
			} catch {
			}

			try {
				path = (string)Microsoft.Win32.Registry.GetValue(
					@"HKEY_LOCAL_MACHINE\SOFTWARE\Dragon's Eye Productions\Furcadia\Programs",
					"Path", null);

				if (path.Length > 0) {
					path += "patches" + Path.DirectorySeparatorChar + "default";
					if (Directory.Exists(path) && File.Exists(Path.Combine(path, "player.fsh")))
						return path;
				}
			} catch {
			}

			path = String.Join(sepString, new string[] {
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
				"Furcadia", "patches", "default"
			});
			if (Directory.Exists(path))
				return path;

			path = String.Join(sepString, new string[] {
				System.Windows.Forms.Application.StartupPath,
				"patches", "default"
			});
			if (Directory.Exists(path))
				return path;

			path = String.Join(sepString, new string[] {
				"C:", "Program Files", "Furcadia", "patches", "default"
			});
			if (Directory.Exists(path))
				return path;

			path = String.Join(sepString, new string[] {
				"C:", "Program Files (x86)", "Furcadia", "patches", "default"
			});
			if (Directory.Exists(path))
				return path;

			// couldn't find any of those, ask the user
			System.Windows.Forms.FolderBrowserDialog fwd = new System.Windows.Forms.FolderBrowserDialog();
			fwd.Description = "Please locate the Furcadia default patch folder.";
			fwd.RootFolder = Environment.SpecialFolder.MyComputer;
			if (fwd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				path = fwd.SelectedPath;
				if (Directory.Exists(path)) {
					FurEd.Properties.Settings.Default.PatchPath = path;
					FurEd.Properties.Settings.Default.Save();
					return path;
				}
			}

			// give up
			System.Windows.Forms.MessageBox.Show("Furcadia does not seem to be installed on your system; or I can't find the default patch folder.\nTo resolve this, you may try reinstalling Furcadia.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			System.Windows.Forms.Application.Exit();
			return null;
		}

		public static string FindDynamicAvatarPath() {
			string path = null;
			string sepString = Path.DirectorySeparatorChar.ToString();

			if (FurEd.Properties.Settings.Default.DynamicAvatarPath != null) {
				path = FurEd.Properties.Settings.Default.DynamicAvatarPath;
				if (Directory.Exists(path) && File.Exists(Path.Combine(path, "DPlayer1.fox")))
					return path;
			}

			path = String.Join(sepString, new string[] {
				Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
				"Dragon's Eye Productions", "Furcadia", "Dynamic Avatars",
			});
			if (Directory.Exists(path) && File.Exists(Path.Combine(path, "DPlayer1.fox")))
				return path;

			// couldn't find any of those, ask the user
			System.Windows.Forms.FolderBrowserDialog fwd = new System.Windows.Forms.FolderBrowserDialog();
			fwd.Description = "Please locate the Furcadia dynamic avatars folder.";
			fwd.RootFolder = Environment.SpecialFolder.MyComputer;
			if (fwd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				path = fwd.SelectedPath;
				if (Directory.Exists(path)) {
					FurEd.Properties.Settings.Default.DynamicAvatarPath = path;
					FurEd.Properties.Settings.Default.Save();
					return path;
				}
			}

			// give up
			System.Windows.Forms.MessageBox.Show("Furcadia does not seem to be installed on your system; or I can't find the dynamic avatar folder.\nTo resolve this, you may try reinstalling Furcadia.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			System.Windows.Forms.Application.Exit();
			return null;
		}

		public static void Prepare() {
			if (PalLoaded) return;
			PalLoaded = true;

			byte[] RawPal = Properties.Resources.palette;
			Color[] ConvPal = new Color[256];
			int FilePos = 0;

			for (int i = 0; i < 256; i++) {
				ConvPal[i] = Color.FromArgb(RawPal[FilePos], RawPal[FilePos + 1], RawPal[FilePos + 2]);
				FilePos += 3;
			}

			ConvPal[0] = Color.Transparent;
			Palette = ConvPal;

			string DefaultPatchPath = CleanupPath(FindPatchPath());

			string DynamicAvatarPath = CleanupPath(FindDynamicAvatarPath());

			Players = new FurcadiaShapes[127];
			for (int i = 1; i < 56; i++) {
				if (i == 35) continue;
				if (i == 1) {
					Players[i] = new FurcadiaShapes(DefaultPatchPath + "player.fsh");
				} else if (i == 48) {
					Players[i] = new FurcadiaShapes(DefaultPatchPath + "player48.fox");
				} else {
					Players[i] = new FurcadiaShapes(DefaultPatchPath + "player" + i.ToString() + ".fsh");
				}
			}

			for (int i = 1; i < 27; i++) {
				Players[100 + i] = new FurcadiaShapes(DynamicAvatarPath + "DPlayer" + i.ToString() + ".fox");
			}

			Portraits = new FurcadiaShapes[127];
			for (int i = 1; i < 42; i++) {
				if (i == 1) {
					Portraits[i] = new FurcadiaShapes(DefaultPatchPath + "portrait.fsh");
				} else {
					Portraits[i] = new FurcadiaShapes(DefaultPatchPath + "portrt" + i.ToString() + ".fsh");
				}
			}

			for (int i = 1; i < 27; i++) {
				Portraits[100 + i] = new FurcadiaShapes(DynamicAvatarPath + "DPort" + i.ToString() + ".fox");
			}
		}

		public static Bitmap Remap(byte[] source, int width, int height, string colourcode, int highlight) {
			byte[] RemappedPal = new byte[256];
			for (int i = 0; i < 256; i++) {
				RemappedPal[i] = (byte)i;
			}

			// try/catch block will allow us to die peacefully if an invalid colour is found
			try {
				// first off parse the colour code into its components
				int FurColour = colourcode[1] - 35;
				int MarkingsColour = colourcode[2] - 35;
				int HairColour = colourcode[3] - 35;
				int EyeColour = colourcode[4] - 35;
				int BadgeColour = colourcode[5] - 35;
				int VestColour = colourcode[6] - 35;
				int BracerColour = colourcode[7] - 35;
				int CapeColour = colourcode[8] - 35;
				int BootColour = colourcode[9] - 35;
				int TrousersColour = colourcode[10] - 35;

				// go through the palette and remap specific bits
				for (int ColIdx = 199; ColIdx <= 206; ColIdx++) {
					RemappedPal[ColIdx] = FurRemap[FurColour][ColIdx - 199];
				}

				for (int ColIdx = 136; ColIdx <= 143; ColIdx++) {
					RemappedPal[ColIdx] = MarkingsRemap[MarkingsColour][ColIdx - 136];
				}

				for (int ColIdx = 128; ColIdx <= 135; ColIdx++) {
					RemappedPal[ColIdx] = HairRemap[HairColour][ColIdx - 128];
				}

				RemappedPal[50] = EyeRemap[EyeColour];
				RemappedPal[11] = BadgeRemap[BadgeColour];

				for (int ColIdx = 72; ColIdx <= 79; ColIdx++) {
					RemappedPal[ColIdx] = VestRemap[VestColour][ColIdx - 72];
				}

				for (int ColIdx = 80; ColIdx <= 87; ColIdx++) {
					RemappedPal[ColIdx] = BracersRemap[BracerColour][ColIdx - 80];
				}

				for (int ColIdx = 32; ColIdx <= 39; ColIdx++) {
					RemappedPal[ColIdx] = CapeRemap[CapeColour][ColIdx - 32];
				}

				for (int ColIdx = 16; ColIdx <= 23; ColIdx++) {
					RemappedPal[ColIdx] = BootRemap[BootColour][ColIdx - 16];
				}

				for (int ColIdx = 224; ColIdx <= 231; ColIdx++) {
					RemappedPal[ColIdx] = TrousersRemap[TrousersColour][ColIdx - 224];
				}

				RemappedPal[10] = 206; // shadows
			} catch {
			}

			// now convert it to a new bitmap
			//Bitmap Source = source.Clone(new Rectangle(0, 0, source.Width, source.Height), PixelFormat.Format8bppIndexed);
			Bitmap Output = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

			//BitmapData SourceBitmapData = source.LockBits(new Rectangle(0, 0, source.Width, source.Height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
			BitmapData DestBitmapData = Output.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

			//byte[] SourceData = new byte[SourceBitmapData.Stride * source.Height];
			//System.Runtime.InteropServices.Marshal.Copy(SourceBitmapData.Scan0, SourceData, 0, SourceData.Length);

			byte[] DestData = new byte[DestBitmapData.Stride * height];
			int Pos = 0;

			for (int Y = height - 1; Y >= 0; Y--) {
				for (int X = 0; X < width; X++) {
					DestData[(DestBitmapData.Stride * Y) + X] = RemappedPal[source[Pos]];
					Pos++;
				}
			}

			//source.UnlockBits(SourceBitmapData);

			System.Runtime.InteropServices.Marshal.Copy(DestData, 0, DestBitmapData.Scan0, DestData.Length);
			Output.UnlockBits(DestBitmapData);

			ColorPalette ThisPal = Output.Palette;
			Palette.CopyTo(ThisPal.Entries, 0);
			Output.Palette = ThisPal;

			if (highlight > -1) {
				Bitmap Orig = Output.Clone(new Rectangle(0, 0, width, height), PixelFormat.Format32bppArgb);
				Output = new Bitmap(width, height, PixelFormat.Format32bppArgb);

				Graphics g = Graphics.FromImage(Output);
				ImageAttributes attr = new ImageAttributes();
				ColorMatrix mtx = new ColorMatrix();
				mtx.Matrix33 = 0.25F;
				attr.SetColorMatrix(mtx, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				g.DrawImage(Orig,
					new Rectangle(0, 0, width, height),
					0, 0, width, height,
					GraphicsUnit.Pixel, attr);
				g.Dispose();

				BitmapData modifyBD = Output.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

				Int32[] data = new Int32[modifyBD.Stride * modifyBD.Height / 4];
				System.Runtime.InteropServices.Marshal.Copy(modifyBD.Scan0, data, 0, data.Length);
				int pos = 0;

				int bound1 = 0, bound2 = 0;

				if (highlight == 0) {
					bound1 = 199; bound2 = 206;
				} else if (highlight == 1) {
					bound1 = 136; bound2 = 143;
				} else if (highlight == 2) {
					bound1 = 128; bound2 = 135;
				} else if (highlight == 3) {
					bound1 = 50; bound2 = 50;
				} else if (highlight == 4) {
					bound1 = 11; bound2 = 11;
				} else if (highlight == 5) {
					bound1 = 72; bound2 = 79;
				} else if (highlight == 6) {
					bound1 = 80; bound2 = 87;
				} else if (highlight == 7) {
					bound1 = 32; bound2 = 39;
				} else if (highlight == 8) {
					bound1 = 16; bound2 = 23;
				} else if (highlight == 9) {
					bound1 = 224; bound2 = 231;
				}

				for (int y = height - 1; y >= 0; y--) {
					for (int x = 0; x < width; x++) {
						byte piece = source[pos];
						if (piece >= bound1 && piece <= bound2) {
							int index = (modifyBD.Stride * y / 4) + x;
							int bit = (bound2 - piece) * 20;
							data[index] = unchecked((int)0xFF0000FF | (bit << 8) | (bit << 16));
						} else if (piece == 207) {
							int index = (modifyBD.Stride * y / 4) + x;
							data[index] = (int)(((uint)data[index]) | 0x80000000);
						}

						pos++;
					}
				}

				System.Runtime.InteropServices.Marshal.Copy(data, 0, modifyBD.Scan0, data.Length);
				Output.UnlockBits(modifyBD);
			}

			return Output;
		}
	}


	public struct Frame {
		[FlagsAttribute]
		public enum FrameFormats : ushort {
			Format8Bit = 1,
			FormatRGB
		}

		public struct Pos {
			public short X;
			public short Y;
		}

		public FrameFormats FrameFormat;
		public ushort Width;
		public ushort Height;
		public Pos FramePos;
		public Pos FurrePos;
		public uint ImageDataSize;
		public byte[] ImageData;
	}

	public struct Shape {
		[FlagsAttribute]
		public enum ShapeFlags : ushort {
			Walkable = 1,
			Gettable = 2,
			Sittable = 4
		}

		public ShapeFlags Flags;
		public short ShapeNum;
		public ushort NumFrames;
		public ushort NumSteps;

		public Frame[] Frames;
		public StepBlock[] KitterSpeak;
	}

	public struct StepBlock {
		public enum StepBlockStepTypes : ushort {
			Frame = 1,
			Delay,
			Loop,
			Jump,
			PosX,
			PosY,
			FurreX,
			FurreY,
			DrawFront,
			DrawBehind,
			AutoFrameDelay,
			Stop,
			CameraState
		}

		public StepBlockStepTypes StepType;
		public short Value;
		public short CounterMax;
	}

	public class FurcadiaShapes {
		public string Header;
		public int Version;
		public int NumShapes;
		public int Generator;
		public int Encryption;
		public int Reserved1;
		public int Reserved2;
		public Shape[] Shapes;

		public FurcadiaShapes(string path) {
			/* Don't fiddle with extensions */
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);
			string header = System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(4)).ToLower();
			br.Close();
			switch (header) {
				case "fshx":
					loadFOX(path);
					break;
				case "fsh2":
					loadFS2(path);
					break;
				default:
					loadFSH(path);
					break;
			}
		}

		void loadFOX(string path) {
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);

			/* Retrieve header information */
			Header = System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(4));
			Version = br.ReadInt32();
			NumShapes = br.ReadInt32();
			Generator = br.ReadInt32();
			Encryption = br.ReadInt32();
			if (Encryption > 0) {
				br.Close();
				throw new Exception("The FOX file (" + path + ") is encrypted and will not be opened.");
			}
			Reserved1 = br.ReadInt32();
			Reserved2 = br.ReadInt32();

			/* Loop through the shapes */
			Shapes = new Shape[NumShapes];
			for (int s = 0; s < NumShapes; s++) {
				/* Retrieve shape header information */
				Shapes[s].Flags = (Shape.ShapeFlags)br.ReadUInt16();
				Shapes[s].ShapeNum = br.ReadInt16();
				Shapes[s].NumFrames = br.ReadUInt16();
				Shapes[s].NumSteps = br.ReadUInt16();

				/* Loop through the frames */
				Shapes[s].Frames = new Frame[Shapes[s].NumFrames];
				for (int f = 0; f < Shapes[s].NumFrames; f++) {
					/* Retrieve frame information */
					Shapes[s].Frames[f].FrameFormat = (Frame.FrameFormats)br.ReadUInt16();
					Shapes[s].Frames[f].Width = br.ReadUInt16();
					Shapes[s].Frames[f].Height = br.ReadUInt16();
					Shapes[s].Frames[f].FramePos.X = br.ReadInt16();
					Shapes[s].Frames[f].FramePos.Y = br.ReadInt16();
					Shapes[s].Frames[f].FurrePos.X = br.ReadInt16();
					Shapes[s].Frames[f].FurrePos.Y = br.ReadInt16();
					Shapes[s].Frames[f].ImageDataSize = br.ReadUInt32();
					Shapes[s].Frames[f].ImageData = br.ReadBytes((int)Shapes[s].Frames[f].ImageDataSize);
				}

				/* Loop through the KitterSpeak */
				Shapes[s].KitterSpeak = new StepBlock[Shapes[s].NumSteps];
				for (int k = 0; k < Shapes[s].NumSteps; k++) {
					/* Retrieve KitterSpeak information */
					Shapes[s].KitterSpeak[k].StepType = (StepBlock.StepBlockStepTypes)br.ReadUInt16();
					Shapes[s].KitterSpeak[k].Value = br.ReadInt16();
					Shapes[s].KitterSpeak[k].CounterMax = br.ReadInt16();
				}
			}

			br.Close();
		}

		void loadFSH(string path) {
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);

			/* Assume/retrieve header information */
			Header = "FSH1";
			Version = 1;
			NumShapes = (int)br.ReadUInt16();
			Generator = 0;
			Encryption = 0;
			Reserved1 = 0;
			Reserved2 = 0;

			/* Skip over chunk sizes */
			for (int s = 0; s < NumShapes; s++) br.ReadUInt16();

			/* Loop through the shapes */
			Shapes = new Shape[NumShapes];
			for (int s = 0; s < NumShapes; s++) {
				Shapes[s].Flags = 0;
				Shapes[s].ShapeNum = 0;
				Shapes[s].NumFrames = 1;
				Shapes[s].NumSteps = 0;

				Shapes[s].Frames = new Frame[1];
				Shapes[s].Frames[0].FrameFormat = Frame.FrameFormats.Format8Bit;
				Shapes[s].Frames[0].Width = (ushort)br.ReadByte();
				Shapes[s].Frames[0].Height = (ushort)br.ReadByte();
				Shapes[s].Frames[0].FramePos.X = (short)br.ReadSByte();
				Shapes[s].Frames[0].FramePos.Y = (short)br.ReadSByte();
				Shapes[s].Frames[0].FurrePos.X = (short)0;
				Shapes[s].Frames[0].FurrePos.Y = (short)0;
				Shapes[s].Frames[0].ImageDataSize = (uint)(Shapes[s].Frames[0].Width * Shapes[s].Frames[0].Height);
				Shapes[s].Frames[0].ImageData = br.ReadBytes((int)Shapes[s].Frames[0].ImageDataSize);
			}

			br.Close();

			try {
				loadFBJ(path);
			} catch { }
		}

		void loadFS2(string path) {
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);

			/* Assume/retrieve header information */
			Header = System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(4)); br.ReadByte();
			Version = Convert.ToInt32(System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(3)));
			NumShapes = br.ReadInt32();
			Generator = 0;
			Encryption = br.ReadInt32();
			if (Encryption > 0) {
				br.Close();
				throw new Exception("The FS2 file (" + path + ") is encrypted and will not be opened.");
			}
			Reserved1 = 0;
			Reserved2 = 0;

			/* Loop through the shapes */
			Shapes = new Shape[NumShapes];
			for (int s = 0; s < NumShapes; s++) {
				Shapes[s].Flags = 0;
				Shapes[s].NumFrames = 1;
				Shapes[s].NumSteps = 0;

				Shapes[s].Frames = new Frame[1];
				Shapes[s].Frames[0].FrameFormat = Frame.FrameFormats.Format8Bit;
				Shapes[s].Frames[0].Width = (ushort)br.ReadByte();
				Shapes[s].Frames[0].Height = (ushort)br.ReadByte();
				Shapes[s].Frames[0].FramePos.X = (short)br.ReadSByte();
				Shapes[s].Frames[0].FramePos.Y = (short)br.ReadSByte();
				Shapes[s].Frames[0].FurrePos.X = (short)0;
				Shapes[s].Frames[0].FurrePos.Y = (short)0;
				Shapes[s].ShapeNum = br.ReadInt16();
				Shapes[s].Frames[0].ImageDataSize = (uint)(Shapes[s].Frames[0].Width * Shapes[s].Frames[0].Height);
				Shapes[s].Frames[0].ImageData = br.ReadBytes((int)Shapes[s].Frames[0].ImageDataSize);
			}

			br.Close();

			try {
				loadFBJ(path);
			} catch {
				/* If it can't load the FBJ, oh well */
			}
		}

		[FlagsAttribute]
		private enum FBJFlags : byte {
			Walkable = 1,
			Gettable = 2,
			Sittable = 4,
			FurreX = 8,
			FurreY = 16
		}

		void loadFBJ(string path) {
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(changeExtension(path, "fbj")).BaseStream);

			/* Ignore header */
			br.ReadBytes(4);
			int chunkCount = br.ReadInt32();

			/* Read object definitions */
			for (int f = 0; f < chunkCount; f++) {
				byte thisFlag = br.ReadByte();
				Shapes[f].Flags = (Shape.ShapeFlags)(thisFlag & 0x07);

				if ((thisFlag & ((byte)FBJFlags.FurreX)) > 0) {
					Shapes[f].Frames[0].FurrePos.X = (short)br.ReadSByte();

					if ((thisFlag & ((byte)FBJFlags.FurreY)) > 0) Shapes[f].Frames[0].FurrePos.Y = (short)br.ReadSByte();
				} else if ((thisFlag & ((byte)FBJFlags.FurreY)) > 0) {
					Shapes[f].Frames[0].FurrePos.Y = (short)br.ReadSByte();
				}
			}

			br.Close();
		}

		string changeExtension(string path, string newExtension) {
			char[] delims = { '/', '\\' };
			string[] structure = path.Split(delims);
			string fullfile = structure[structure.GetUpperBound(0)];
			string filename = fullfile.Substring(0, fullfile.LastIndexOf('.'));
			string filepath = path.Substring(0, path.LastIndexOfAny(delims) + 1);
			return (filepath + filename + "." + newExtension);
		}
	}
}
