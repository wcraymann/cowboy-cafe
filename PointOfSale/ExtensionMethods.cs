/*
 * Author: Nathan Bean
 * Written by: William Raymann
 * Class: ExtensionMethods
 * Purpose: To make additional functionality to classes withing the PointOfSale 
 *          namespace available as needed.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finds the first parent of the calling element that is
        /// the type specified by the calling element.
        /// </summary>
        /// <typeparam name="T">The type of parent we are looking for.</typeparam>
        /// <param name="element">The calling element.</param>
        /// <returns>The first parent of type T.</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
