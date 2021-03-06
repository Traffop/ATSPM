﻿namespace MOE.Common.Models.Inrix.Repositories
{
    public class RouteRepositoryFactory
    {
        private static IRouteRepository routeRepository;

        public static IRouteRepository CreateRepository()
        {
            if (routeRepository != null)
                return routeRepository;
            return new RouteRepository();
        }

        public static void SetRepository(IRouteRepository newRouteRepository)
        {
            routeRepository = newRouteRepository;
        }
    }
}