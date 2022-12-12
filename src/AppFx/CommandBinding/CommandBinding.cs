namespace AppFx.CommandBinding;

public class CommandBinding
{
    public delegate void EnableChangedEventHandler(object sender, EnableChangedEventArgs e);
    public delegate void VisibleChangedEventHandler(object sender, VisibleChangedEventArgs e);
    public delegate void SelectedChangedEventHandler(object sender, SelectedChangedEventArgs e);

    public event EnableChangedEventHandler? EnableChanged;
    public event VisibleChangedEventHandler? VisibleChanged;
    public event SelectedChangedEventHandler? SelectedChanged;

    private bool isEnabled = true;
    private bool isVisible = true;
    private bool isSelected = true;

    private readonly Action action;

    public CommandBinding(Action action)
    {
        this.action = action;
    }

    public bool IsEnabled
    {
        get
        {
            return isEnabled;
        }
        set
        {
            if (isEnabled != value)
            {
                isEnabled = value;
                EnableChanged?.Invoke(this, new EnableChangedEventArgs(IsEnabled));
            }
        }
    }

    public bool IsVisible
    {
        get
        {
            return isVisible;
        }
        set
        {
            if (isVisible != value)
            {
                isVisible = value;
                VisibleChanged?.Invoke(this, new VisibleChangedEventArgs(IsVisible));
            }
        }
    }

    public bool IsSelected
    {
        get
        {
            return isSelected;
        }
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                SelectedChanged?.Invoke(this, new SelectedChangedEventArgs(IsSelected));
            }
        }
    }

    public virtual void Execute()
    {
        // Default viselkedés, a leszármazottban felül lehet definiálni
        action();
    }


    public class EnableChangedEventArgs : EventArgs
    {
        public bool IsEnabled { get; }

        public EnableChangedEventArgs(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }
    }

    public class VisibleChangedEventArgs : EventArgs
    {
        public bool IsVisible { get; }

        public VisibleChangedEventArgs(bool isEnabled)
        {
            IsVisible = isEnabled;
        }
    }

    public class SelectedChangedEventArgs : EventArgs
    {
        public bool IsSelected { get; }

        public SelectedChangedEventArgs(bool isSelected)
        {
            IsSelected = isSelected;
        }
    }
}
