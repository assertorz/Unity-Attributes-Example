﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    // Add ExcludeFromObjectFactory attribute to a class to prevent the class and its inherited classes from being created with ObjectFactory methods.

    [ExcludeFromObjectFactory]
    public class ExcludeFromObjectFactoryExample : MonoBehaviour {

        public int aa = 24;

    }

}
