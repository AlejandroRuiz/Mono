/**
 *               DO WHAT YOU WANT TO PUBLIC LICENSE
 *                    Version 2, December 2004
 * 
 * Copyright (C) 2004 Sam Hocevar <sam@hocevar.net>
 * 
 * Everyone is permitted to copy and distribute verbatim or modified
 * copies of this license document, and changing it is allowed as long
 * as the name is changed.
 * 
 *            DO WHAT YOU WANT TO PUBLIC LICENSE
 *   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION
 * 
 *  0. You just DO WHAT YOU WANT TO.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.Text;
using Android.Util;
/**
 * Text view that auto adjusts text size to fit within the view.
 * If the text size equals the minimum text size and still does not
 * fit, append with an ellipsis.
 * 
 * @author Chase Colburn
 * @since Apr 4, 2011
 */
using Java.Lang;


namespace Meme.Droid
{
	public class AutoResizeTextView: TextView
	{
		// Minimum text size for this text view
		public static float MIN_TEXT_SIZE = 20;


		public interface OnTextResizeListener
		{
			void onTextResize(TextView textView, float oldSize, float newSize);
		}

		// Our ellipse string
		private static string mEllipsis = "...";

		// Registered resize listener
		private OnTextResizeListener mTextResizeListener;

		// Flag for text and/or size changes to force a resize
		private bool mNeedsResize = false;

		// Text size that is set from code. This acts as a starting point for resizing
		private float mTextSize;

		// Temporary upper bounds on the starting text size
		private float mMaxTextSize = 0;

		// Lower bounds for text size
		private float mMinTextSize = MIN_TEXT_SIZE;

		// Text view line spacing multiplier
		private float mSpacingMult = 1.0f;

		// Text view additional line spacing
		private float mSpacingAdd = 0.0f;

		// Add ellipsis to text that overflows at the smallest text size
		private bool mAddEllipsis = true;



		protected AutoResizeTextView(IntPtr javaReference, JniHandleOwnership transfer) 
			: base(javaReference, transfer)
		{
		}

		public AutoResizeTextView (Context context):this(context, null) {
		}
			
		public AutoResizeTextView(Context context, IAttributeSet attrs): this(context, attrs, 0) {
		}


		public AutoResizeTextView(Context context, IAttributeSet attrs, int defStyle):base(context, attrs, defStyle) {
			mTextSize = this.TextSize;
		}


		protected override void OnTextChanged (Java.Lang.ICharSequence text, int start, int before, int after)
		{
			base.OnTextChanged (text, start, before, after);
			mNeedsResize = true;
			// Since this view may be reused, it is good to reset the text size
			resetTextSize();
		}

		protected override void OnSizeChanged (int w, int h, int oldw, int oldh)
		{
			base.OnSizeChanged (w, h, oldw, oldh);
			if (w != oldw || h != oldh) {
				mNeedsResize = true;
			}
		}

		/**
     * Register listener to receive resize notifications
     * @param listener
     */
		public void setOnResizeListener(OnTextResizeListener listener) {
			mTextResizeListener = listener;
		}

		public override void SetTextSize (ComplexUnitType unit, float size)
		{
			base.SetTextSize(unit,size);
			mTextSize = this.TextSize;
		}

		public override void SetLineSpacing (float add, float mult)
		{
			base.SetLineSpacing (add, mult);
			mSpacingMult = mult;
			mSpacingAdd = add;
		}

		/**
     * Set the upper text size limit and invalidate the view
     * @param maxTextSize
     */
		public void setMaxTextSize(float maxTextSize) {
			mMaxTextSize = maxTextSize;
			this.RequestLayout ();
			this.Invalidate ();
		}

		/**
     * Return upper text size limit
     * @return
     */
		public float getMaxTextSize() {
			return mMaxTextSize;
		}

		/**
     * Set the lower text size limit and invalidate the view
     * @param minTextSize
     */
		public void setMinTextSize(float minTextSize) {
			mMinTextSize = minTextSize;
			this.RequestLayout();
			this.Invalidate();
		}

		/**
     * Return lower text size limit
     * @return
     */
		public float getMinTextSize() {
			return mMinTextSize;
		}

		/**
     * Set flag to add ellipsis to text that overflows at the smallest text size
     * @param addEllipsis
     */
		public void setAddEllipsis(bool addEllipsis) {
			mAddEllipsis = addEllipsis;
		}

		/**
     * Return flag to add ellipsis to text that overflows at the smallest text size
     * @return
     */
		public bool getAddEllipsis() {
			return mAddEllipsis;
		}

		/**
     * Reset the text to the original size
     */
		public void resetTextSize() {
			if (mTextSize > 0) {
				base.SetTextSize (ComplexUnitType.Px, mTextSize);
				mMaxTextSize = mTextSize;
			}
		}

		protected override void OnLayout (bool changed, int left, int top, int right, int bottom)
		{
			if (changed || mNeedsResize) {
				int widthLimit = (right - left) - this.PaddingLeft - this.PaddingRight;
				int heightLimit = (bottom - top) - this.PaddingBottom - this.PaddingTop;
				resizeText(widthLimit, heightLimit);
			}
			base.OnLayout (changed, left, top, right, bottom);
		}
			
		public void resizeText() {

			int heightLimit = this.Height - this.PaddingBottom - this.PaddingTop;
			int widthLimit = this.Width - this.PaddingLeft - this.PaddingRight;
			resizeText(widthLimit, heightLimit);
		}

		public void resizeText(int width, int height) {
			string text = this.Text;
			// Do not resize if the view does not have dimensions or there is no text
			if (text == null || text.Length == 0 || height <= 0 || width <= 0 || mTextSize == 0) {
				return;
			}

			// Get the text view's paint object
			TextPaint textPaint = this.Paint;

			// Store the current text size
			float oldTextSize = textPaint.TextSize;
			// If there is a max text size set, use the lesser of that and the default text size
			float targetTextSize = mMaxTextSize > 0 ? Java.Lang.Math.Min(mTextSize, mMaxTextSize) : mTextSize;

			// Get the required text height
			int textHeight =  getTextHeight(text, textPaint, width, targetTextSize);

			// Until we either fit within our text view or we had reached our min text size, incrementally try smaller sizes
			while (textHeight > height && targetTextSize > mMinTextSize) {
				targetTextSize = Java.Lang.Math.Max(targetTextSize - 2, mMinTextSize);
				textHeight = getTextHeight(text, textPaint, width, targetTextSize);
			}

			// If we had reached our minimum text size and still don't fit, append an ellipsis
			if (mAddEllipsis && targetTextSize == mMinTextSize && textHeight > height) {
				// Draw using a static layout
				// modified: use a copy of TextPaint for measuring
				TextPaint paint = new TextPaint(textPaint);
				// Draw using a static layout
				StaticLayout layout = new StaticLayout(text, paint, width, Android.Text.Layout.Alignment.AlignNormal, mSpacingMult, mSpacingAdd, false);
				// Check that we have a least one line of rendered text
				if (layout.LineCount > 0) {
					// Since the line at the specific vertical position would be cut off,
					// we must trim up to the previous line
					int lastLine = layout.GetLineForVertical(height) - 1;
					// If the text would not even fit on a single line, clear it
					if (lastLine < 0) {
						this.Text = "";
					}
					// Otherwise, trim to the previous line and add an ellipsis
					else {
						int start = layout.GetLineStart(lastLine);
						int end = layout.GetLineEnd(lastLine);
						float lineWidth = layout.GetLineWidth(lastLine);
						float ellipseWidth = textPaint.MeasureText(mEllipsis);

						// Trim characters off until we have enough room to draw the ellipsis
						while (width < lineWidth + ellipseWidth) {
							lineWidth = textPaint.MeasureText(text.Substring(start, --end + 1).ToString());
						}
						this.Text = text.Substring(0, end) + mEllipsis;
					}
				}
			}

			// Some devices try to auto adjust line spacing, so force default line spacing
			// and invalidate the layout as a side effect
			this.SetTextSize(ComplexUnitType.Px, targetTextSize);
			this.SetLineSpacing(mSpacingAdd, mSpacingMult);

			// Notify the listener if registered
			if (mTextResizeListener != null) {
				mTextResizeListener.onTextResize(this, oldTextSize, targetTextSize);
			}

			// Reset force resize flag
			mNeedsResize = false;
		}

		private int getTextHeight(string source, TextPaint paint, int width, float textSize) {
			// modified: make a copy of the original TextPaint object for measuring
			// (apparently the object gets modified while measuring, see also the
			// docs for TextView.getPaint() (which states to access it read-only)
			TextPaint paintCopy = new TextPaint(paint);
			// Update the text paint object
			paintCopy.TextSize = textSize;
			// Measure using a static layout
			StaticLayout layout = new StaticLayout(source, paintCopy, width, Android.Text.Layout.Alignment.AlignNormal, mSpacingMult, mSpacingAdd, true);
			return layout.Height;
		}
	}
}