﻿namespace NextGateForPrism.Unity.Forms
{
    public static class UnityContainerExtensions
    {
        public static IUnityContainer RegisterTypeForViewModelNavigation<TView, TViewModel>(this IUnityContainer container)
                    where TView : Page
                    where TViewModel : class
        {
            var viewType = typeof(TView);
            ViewModelLocationProvider.Register(viewType.ToString(), typeof(TViewModel));
            return container.RegisterTypeForNavigation(viewType, typeof(TViewModel).FullName);
        }
    }
}
