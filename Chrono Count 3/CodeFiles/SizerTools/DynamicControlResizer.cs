namespace Dyanmic_Form_Sizing_Testing
{
    class DynamicControlResizer
    {
        private readonly Form form;
        private Rectangle originalFormSize;
        private readonly Control[] item_array;
        private readonly Rectangle[] size_array;

        public DynamicControlResizer(Form Form) 
        {
            form = Form;
            originalFormSize = new Rectangle(form.Location.X, form.Location.Y, form.Width, form.Height);
            item_array = [.. Form.Controls.Cast<Control>()];
            size_array = GetSizes(item_array);
        }

        private static Rectangle[] GetSizes(Control[] items)
        {
            List<Rectangle> tempSizes = [];
            foreach (var item in items)
            {
                tempSizes.Add(new Rectangle(item.Location.X, item.Location.Y, item.Width, item.Height));
            }
            return [.. tempSizes];
        }

        public void ResizeForm() 
        {
            for (int i = 0; i < item_array.Length; i++)
            {
                ResizeControl(size_array[i], item_array[i]);
            }
        }
        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(form.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(form.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Width = newWidth;
            c.Height = newHeight;
        }

        public void ResizeFormHorizontally()
        {
            for (int i = 0; i < item_array.Length; i++)
            {
                ResizeControlHorizontally(size_array[i], item_array[i]);
            }
        }
        private void ResizeControlHorizontally(Rectangle r, Control c)
        {
            float xRatio = (float)(form.Width) / (float)(originalFormSize.Width);

            int newX = (int)(r.X * xRatio);

            int newWidth = (int)(r.Width * xRatio);

            int newY = r.Y;
            int newHeight = r.Height;

            c.Location = new Point(newX, newY);
            c.Width = newWidth;
            c.Height = newHeight;
        }

        public void ResizeFormVertically()
        {
            for (int i = 0; i < item_array.Length; i++)
            {
                ResizeControlVertically(size_array[i], item_array[i]);
            }
        }
        private void ResizeControlVertically(Rectangle r, Control c)
        {
            float yRatio = (float)(form.Height) / (float)(originalFormSize.Height);

            int newY = (int)(r.Y * yRatio);

            int newHeight = (int)(r.Height * yRatio);

            int newX = r.X;
            int newWidth = r.Width;

            c.Location = new Point(newX, newY);
            c.Width = newWidth;
            c.Height = newHeight;
        }
    }
}
